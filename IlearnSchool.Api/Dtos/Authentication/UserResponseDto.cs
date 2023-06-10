namespace IlearnSchool.Api.Dtos.Authentication;

public class UserResponseDto
{
    public string Email { get; set; } = null!;
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Token { get; set; } = null!;
}