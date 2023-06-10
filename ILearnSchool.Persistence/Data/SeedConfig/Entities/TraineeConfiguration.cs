using ILearnSchool.Core.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ILearnSchool.Persistence.Data.SeedConfig.Entities;

public class TraineeConfiguration : IEntityTypeConfiguration<Trainee>
{
    public void Configure(EntityTypeBuilder<Trainee> builder)
    {
        builder.HasData(
      new Trainee { Id = 1, FirstName = "Laila", LastName = "Mostapha", Age = 18, DepartmentId = 1 },
      new Trainee { Id = 2, FirstName = "Ali", LastName = "Ahemd", Age = 19, DepartmentId = 2 },
      new Trainee { Id = 3, FirstName = "Omar", LastName = "Taha", Age = 20, DepartmentId = 3 },
      new Trainee { Id = 4, FirstName = "Akram", LastName = "Samy", Age = 22, DepartmentId = 4 }
  );
    }
}
