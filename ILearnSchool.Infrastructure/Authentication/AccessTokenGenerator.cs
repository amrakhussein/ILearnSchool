using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

using ILearnSchool.Core.Interfaces.Infrastructure.Authentication;
using ILearnSchool.Core.Interfaces.Infrastructure.Services;
using ILearnSchool.Core.Models;

using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace ILearnSchool.Persistence.Authentication;
/// <summary>
/// Generated Access Token Having User Roles
/// </summary>
public class AccessTokenGenerator : IAccessTokenGenerator
{
    private readonly IDateTimeProvider _dateTimeProvider;
    private readonly JwtSettings _jwtSettings;
    private readonly UserManager<ApplicationUser> _userManager;

    public AccessTokenGenerator(IDateTimeProvider dateTimeProvider, IOptions<JwtSettings> jwtOptions, UserManager<ApplicationUser> userManager)
    {
        _dateTimeProvider = dateTimeProvider;
        _jwtSettings = jwtOptions.Value;
        _userManager = userManager;
    }

    public async Task<string> GenerateAccessTokenAsync(ApplicationUser user)
    {
        // Generate Access Token
        var generatedAccessToken = await GenerateJwtTokenAsync(user);
        string generatedAccessTokenSerialized = new JwtSecurityTokenHandler().WriteToken(generatedAccessToken);

        return generatedAccessTokenSerialized;
    }

    private async Task<JwtSecurityToken> GenerateJwtTokenAsync(ApplicationUser user)
    {
        // Generate user claims
        var claims = await GenerateClaimsAsync(user.FirstName, user.LastName, user.Email);

        // Generate signing credentials
        SigningCredentials signingCredetials = GenerateSigningCredentials();

        // Generate security tokens
        JwtSecurityToken securityToken = GenerateSecurityToken(signingCredetials, claims);

        return securityToken;
    }

    private SigningCredentials GenerateSigningCredentials()
    {
        var key = Encoding.UTF8.GetBytes(_jwtSettings.Secret);

        // Sign & verify security tokens
        var symmetricSecurityKey = new SymmetricSecurityKey(key);

        return new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);
    }

    private JwtSecurityToken GenerateSecurityToken(SigningCredentials signingCredetials, List<Claim> claims)
    {
        return new JwtSecurityToken(issuer: _jwtSettings.Issuer,
                                    audience: _jwtSettings.Audience,
                                    expires: _dateTimeProvider.UtcNow.AddMinutes(_jwtSettings.ExpiryMinutes),
                                    claims: claims,
                                    signingCredentials: signingCredetials);
    }

    private async Task<List<Claim>> GenerateClaimsAsync(string firstName, string lastName, string username)
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

            // Attach user roles to claims
            if (roles is not null && roles.Count > 0)
            {
                foreach (var role in roles)
                {
                    claims.Add(new Claim(ClaimTypes.Role, role));
                }
            }
        }

        return claims;
    }
}
