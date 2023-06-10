using ILearnSchool.Core.Models;

namespace ILearnSchool.Core.Interfaces.Authentication
{
    public interface IJwtTokenGenerator
    {
        Task<string> GenerateJwtTokenAsync(ApplicationUser user);
    }
}
