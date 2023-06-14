using ErrorOr;

using IlearnSchool.Core.Dtos.Authentication;

using ILearnSchool.Core.Helper;
using ILearnSchool.Core.Interfaces.Infrastructure.Authentication;
using ILearnSchool.Core.Interfaces.Persistence;
using ILearnSchool.Core.Models;
using ILearnSchool.Core.ServiceErrors;

using MediatR;

using Microsoft.AspNetCore.Identity;

namespace ILearnSchool.Core.Features.Authentication.Commands.Register;

public class RegisterCommandHandler : IRequestHandler<RegisterCommand, ErrorOr<AuthenticatedUserResponseDto>>
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;
    private readonly IUserRepository _userRepository;

    public RegisterCommandHandler(IJwtTokenGenerator jwtTokenGenerator, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IUserRepository userRepository)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
        _userManager = userManager;
        _signInManager = signInManager;
        _userRepository = userRepository;
    }

    public async Task<ErrorOr<AuthenticatedUserResponseDto>> Handle(RegisterCommand command, CancellationToken cancellationToken)
    {
        var user = await _userManager.FindByEmailAsync(command.Email);

        // Check if a user with the given email already exists
        if (user is not null)
        {
            return Errors.User.DublicateEmail;
        }

        var newUser = new ApplicationUser
        {
            FirstName = command.FirstName,
            LastName = command.LastName,
            Email = command.Email,
            UserName = command.Email // Set the username to the email
        };

        try
        {
            // Persist the new user
            var userAdded = await _userRepository.AddAsync(newUser, command.Password);
            if (!userAdded) return Errors.User.CreatingUserFailed;

            string[] userRoles = command.Roles;
            if (userRoles != null && command.Roles.Length > 0)
            {
                try
                {
                    foreach (var role in command.Roles)
                    {
                        if (!UserRoleChecker.Contains(role))
                        {
                            throw new ArgumentException($"Invalid role '{role}' name");
                        }
                    }

                    // Attach user roles
                    await _userManager.AddToRolesAsync(newUser, userRoles);

                }
                catch
                {
                    // Remove the user if adding roles failed
                    await _userRepository.RemoveAsync(newUser);

                    // Todo: consider error variation
                    return Errors.User.CreatingUserRolesFailed;
                }
            }


            // Generate a JWT token for the new user
            var generatedUserToken = await _jwtTokenGenerator.GenerateJwtTokenAsync(newUser);

            return new AuthenticatedUserResponseDto
            {
                FirstName = newUser.FirstName,
                LastName = newUser.LastName,
                Email = newUser.Email,
                Token = generatedUserToken
            };
        }
        catch
        {
            // Remove the user if unexpected error occured
            await _userRepository.RemoveAsync(newUser);

            return Error.Unexpected();
        }
    }


}
