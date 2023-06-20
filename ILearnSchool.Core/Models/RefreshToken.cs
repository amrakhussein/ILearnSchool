namespace ILearnSchool.Core.Models;

public class RefreshToken
{
    public int Id { get; set; }
    public string UserId { get; set; } = null!;
    public string Token { get; set; } = null!;
    public DateTime AddedDate { get; set; } = DateTime.UtcNow;
    public DateTime? RevokedAt { get; set; }
    public DateTime ExpiryDate { get; set; }
    public bool HasExpired => DateTime.UtcNow >= ExpiryDate;
    public bool IsActive => RevokedAt is null && !HasExpired;
}

