namespace IlearnSchool.Core.Dtos.Authentication;

public record RegisterUserDto(string FirstName,
                              string LastName,
                              string Email,
                              string Password,
                              string[] Roles);
