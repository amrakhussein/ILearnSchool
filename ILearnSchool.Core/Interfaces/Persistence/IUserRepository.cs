using ILearnSchool.Core.Models;

namespace ILearnSchool.Core.Interfaces.Persistence;

public interface IUserRepository
{
    Task<ApplicationUser>? GetByEmailAsync(string email);
    Task<bool> AddAsync(ApplicationUser user, string password);
    Task<bool> RemoveAsync(ApplicationUser user);
    Task<bool> ValidatePasswordAsync(ApplicationUser user, string password, bool lockoutOnFailure = false);
}
