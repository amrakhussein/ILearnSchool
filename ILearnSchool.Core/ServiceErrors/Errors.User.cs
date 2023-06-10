using ErrorOr;

namespace ILearnSchool.Core.ServiceErrors;

public static partial class Errors
{
    public static class User
    {
        public static Error DublicateEmail => Error.Conflict(code: "User.DublicateEmail",
                                                             description: "User with given email address already exists");

        public static Error CreatingUserFailed => Error.Failure(
          code: "User.CreatingUserFailed",
          description: $" Error occured while adding new user");

        public static Error CreatingUserRolesFailed => Error.Failure(code: "User.CreatingRolesFailed",
                                                                     description: "Error occurred while adding user roles");
    }
}
