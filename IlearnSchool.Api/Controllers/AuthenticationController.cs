using ErrorOr;

using IlearnSchool.Api.Dtos.Authentication;

using ILearnSchool.Core.Features.Authentication.Common;
using ILearnSchool.Core.Features.Authentication.Login;
using ILearnSchool.Core.Features.Authentication.Register;

using Mapster;

using MapsterMapper;

using MediatR;

using Microsoft.AspNetCore.Mvc;

namespace IlearnSchool.Api.Controllers;

[Route("auth")]
public class AuthenticationController : ApiController
{
    private readonly IMapper _mapper;
    private readonly ISender _mediator;

    public AuthenticationController(IMapper mapper, IMediator mediator)
    {
        _mapper = mapper;
        _mediator = mediator;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register(RegisterUserDto userDto)
    {
        var registerCommand = _mapper.Map<RegisterCommand>(userDto);

        ErrorOr<AuthenticationResult> authenticationResult = await _mediator.Send(registerCommand);
        var test = _mapper.Map<UserResponseDto>(authenticationResult);
        var userResponseDto = authenticationResult.Adapt<UserResponseDto>();

        return authenticationResult.Match(authResult => Ok(_mapper.Map<UserResponseDto>(authenticationResult)),
                                errors => Problem(errors));
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginUserDto loginDto)
    {
        var loginQuery = _mapper.Map<LoginQuery>(loginDto);
        ErrorOr<AuthenticationResult> authenticationResult = await _mediator.Send(loginQuery);

        // Todo:: filter out sensitive errors from client
        return authenticationResult.Match(authResults => Ok(_mapper.Map<UserResponseDto>(authenticationResult)),
            errors => Problem(errors));
    }

}
