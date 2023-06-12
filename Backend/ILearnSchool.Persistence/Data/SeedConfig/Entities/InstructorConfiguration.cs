using ILearnSchool.Core.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ILearnSchool.Persistence.Data.SeedConfig.Entities;

public class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
{
    public void Configure(EntityTypeBuilder<Instructor> builder)
    {
        builder.HasData(
             new Instructor { Id = 1, FirstName = "Amr", LastName = "Samy", Age = 30, DepartmentId = 1 },
             new Instructor { Id = 2, FirstName = "Samy", LastName = "Ramy", Age = 35, DepartmentId = 2 },
             new Instructor { Id = 3, FirstName = "Jasmine", LastName = "Ahmed", Age = 40, DepartmentId = 3 },
             new Instructor { Id = 4, FirstName = "Ayman", LastName = "Akram", Age = 45, DepartmentId = 4 }
         );
    }
}
