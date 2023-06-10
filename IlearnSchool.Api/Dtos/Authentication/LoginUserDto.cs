using System.ComponentModel.DataAnnotations;

namespace IlearnSchool.Api.Dtos.Authentication;

public class LoginUserDto
{
    [Required]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; } = null!;

    [Required]
    public string Password { get; set; } = null!;
}
