using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

using ILearnSchool.Core.Interfaces.Authentication;
using ILearnSchool.Core.Interfaces.Services;
using ILearnSchool.Core.Models;

using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace ILearnSchool.Persistence.Authentication;

public class JwtTokenGenerator : IJwtTokenGenerator
{
    private readonly IDateTimeProvider _dateTimeProvider;
    private readonly JwtSettings _jwtSettings;
    private readonly UserManager<ApplicationUser> _userManager;

    public JwtTokenGenerator(IDateTimeProvider dateTimeProvider, IOptions<JwtSettings> jwtOptions, UserManager<ApplicationUser> userManager)
    {
        _dateTimeProvider = dateTimeProvider;
        _jwtSettings = jwtOptions.Value;
        _userManager = userManager;
    }

    public async Task<string> GenerateJwtTokenAsync(ApplicationUser user)
    {
        // Generate signing credentials
        SigningCredentials signingCredetials = GenerateSigningCredentials();

        // Generate user claims
        Claim[] claims = await GenerateClaimsAsync(user.FirstName, user.LastName, user.UserName ?? user.Email);

        // Generate security tokens
        JwtSecurityToken securityToken = GenerateSecurityTokens(signingCredetials, claims);

        return new JwtSecurityTokenHandler().WriteToken(securityToken);
    }

    private SigningCredentials GenerateSigningCredentials()
    {
        var key = Encoding.UTF8.GetBytes(_jwtSettings.Secret);

        // Sign & verify security tokens
        var symmetricSecurityKey = new SymmetricSecurityKey(key);

        return new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);
    }

    private JwtSecurityToken GenerateSecurityTokens(SigningCredentials signingCredetials, Claim[] claims)
    {
        return new JwtSecurityToken(issuer: _jwtSettings.Issuer,
                                    audience: _jwtSettings.Audience,
                                    expires: _dateTimeProvider.UtcNow.AddMinutes(_jwtSettings.ExpiryMinutes),
                                    claims: claims,
                                    signingCredentials: signingCredetials);
    }

    private async Task<Claim[]> GenerateClaimsAsync(string firstName, string lastName, string username)
    {
        var claims = new List<Claim>
    {
        new Claim(JwtRegisteredClaimNames.GivenName, firstName),
        new Claim(JwtRegisteredClaimNames.FamilyName, lastName),
        new Claim(JwtRegisteredClaimNames.Sub, username.ToString())
    };
        var user = await _userManager.FindByNameAsync(username);
        if (user is not null)
        {
            var roles = await _userManager.GetRolesAsync(user);

            // Add role claims
            if (roles is not null && roles.Count > 0)
            {
                foreach (var role in roles)
                {
                    claims.Add(new Claim(ClaimTypes.Role, role));
                }
            }
        }

        return claims.ToArray();
    }
}
