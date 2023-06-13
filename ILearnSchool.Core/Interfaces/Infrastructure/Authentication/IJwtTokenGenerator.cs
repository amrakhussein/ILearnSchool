using ILearnSchool.Core.Models;

namespace ILearnSchool.Core.Interfaces.Infrastructure.Authentication
{
    public interface IJwtTokenGenerator
    {
        Task<string> GenerateJwtTokenAsync(ApplicationUser user);
    }
}
