using ILearnSchool.Persistence.Data.Constants;

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ILearnSchool.Persistence.Data.SeedConfig.Entities;

public class RolesConfiguration : IEntityTypeConfiguration<IdentityRole>
{
    public void Configure(EntityTypeBuilder<IdentityRole> builder)
    {
        builder.HasData(
           new IdentityRole
           {
               Name = RoleSettings.Admin,
               NormalizedName = RoleSettings.Admin.ToUpper(),
           },
             new IdentityRole
             {
                 Name = RoleSettings.User,
                 NormalizedName = RoleSettings.User.ToUpper(),
             },
               new IdentityRole
               {
                   Name = RoleSettings.Guest,
                   NormalizedName = RoleSettings.Guest.ToUpper(),
               }
           );
    }
}
