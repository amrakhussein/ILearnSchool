using System.ComponentModel.DataAnnotations;

namespace IlearnSchool.Api.Dtos.Authentication;

public class RegisterUserDto
{
    [Required]
    public string FirstName { get; set; } = null!;

    [Required]
    public string LastName { get; set; } = null!;

    [Required]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; } = null!;

    [Required]
    public string Password { get; set; } = null!;

    public string[] Roles { get; set; } = null!;
}

