using ILearnSchool.Core.Interfaces.Persistence;
using ILearnSchool.Core.Models;

using Microsoft.AspNetCore.Identity;

namespace ILearnSchool.Persistence.Persistence;

public class UserRepository : IUserRepository
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;


    public UserRepository(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
    {
        _userManager = userManager;
        _signInManager = signInManager;
    }

    public async Task<bool> AddAsync(ApplicationUser user, string password)
    {
        var userAdded = await _userManager.CreateAsync(user, password);

        return userAdded.Succeeded;
    }

    public async Task<bool> RemoveAsync(ApplicationUser user)
    {
        var userRemoved = await _userManager.DeleteAsync(user);

        return userRemoved.Succeeded;
    }
    public async Task<ApplicationUser>? GetByEmailAsync(string email)
    {
        var userFound = await _userManager.FindByEmailAsync(email);

        return userFound;
    }

    public async Task<bool> ValidatePasswordAsync(ApplicationUser user, string password, bool lockoutOnFailure = false)
    {
        var userValidated = await _signInManager.CheckPasswordSignInAsync(user, password, lockoutOnFailure);

        return userValidated.Succeeded;
    }
}
