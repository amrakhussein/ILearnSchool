﻿using System.ComponentModel.DataAnnotations;

using Microsoft.AspNetCore.Identity;

namespace ILearnSchool.Core.Models;

public class ApplicationUser : IdentityUser
{
    [Required, MaxLength(100)]
    public string FirstName { get; set; } = null!;

    [Required, MaxLength(100)]
    public string LastName { get; set; } = null!;
}
