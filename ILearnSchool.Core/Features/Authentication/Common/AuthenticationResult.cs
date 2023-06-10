using ILearnSchool.Core.Models;

namespace ILearnSchool.Core.Features.Authentication.Common;

public record AuthenticationResult(ApplicationUser User,
                                   string Token);

