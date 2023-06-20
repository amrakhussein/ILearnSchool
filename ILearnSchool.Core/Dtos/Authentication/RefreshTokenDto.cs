namespace IlearnSchool.Core.Dtos.Authentication;

public class RefreshTokenDto
{
    public string RefreshToken { get; set; } = null!;
    public DateTime ExpiryDate { get; set; }
}