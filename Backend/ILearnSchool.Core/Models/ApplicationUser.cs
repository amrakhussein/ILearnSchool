using System.ComponentModel.DataAnnotations;



namespace IlearnSchool.Api.Models;

public class ApplicationUser : IdentityUser
{
    [Required, MaxLength(100)]
    public string FirstName { get; set; } = null!;

    [Required, MaxLength(100)]
    public string LastName { get; set; } = null!;
}
