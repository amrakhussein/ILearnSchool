using ILearnSchool.Core.Constants;

namespace ILearnSchool.Core.Helper;
/// <summary>
/// Helper class for checking if a role exists.
/// </summary>
public class UserRoleChecker
{
    /// <summary>
    /// Checks if the given role exists.
    /// </summary>
    /// <param name="role">The role to check.</param>
    /// <returns>True if the role exists; otherwise, false.</returns>
    public static bool Contains(string role)
    {
        return string.Equals(role, RoleSettings.Admin, StringComparison.OrdinalIgnoreCase) ||
               string.Equals(role, RoleSettings.User, StringComparison.OrdinalIgnoreCase) ||
               string.Equals(role, RoleSettings.Guest, StringComparison.OrdinalIgnoreCase);
    }
}
