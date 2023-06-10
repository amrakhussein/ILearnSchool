namespace ILearnSchool.Core.Constants;

public class RoleSettings
{
    public const string Admin = "Admin";
    public const string User = "User";
    public const string Guest = "Guest";

    public static bool Contains(string role)
    {
        return String.Equals(role, Admin, StringComparison.OrdinalIgnoreCase) ||
               String.Equals(role, User, StringComparison.OrdinalIgnoreCase) ||
               String.Equals(role, Guest, StringComparison.OrdinalIgnoreCase);
    }
}
