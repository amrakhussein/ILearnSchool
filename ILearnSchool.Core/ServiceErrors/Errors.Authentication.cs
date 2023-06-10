using ErrorOr;

namespace ILearnSchool.Core.ServiceErrors;

public static partial class Errors
{
    public static class Authentication
    {
        public static Error InvalidCredentials => Error.Validation(
            code: "Auth.InvalidCredentials",
            description: "Invalid credentials");
    }
}
