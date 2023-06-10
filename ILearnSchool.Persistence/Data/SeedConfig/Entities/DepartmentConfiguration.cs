using ILearnSchool.Core.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ILearnSchool.Persistence.Data.SeedConfig.Entities;

public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
{
    public void Configure(EntityTypeBuilder<Department> builder)
    {

        builder.HasData(
            new Department
            {
                Id = 1,
                Name = "Computer Science",
                Description = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium"
            },
            new Department
            {
                Id = 2,
                Name = "Arts",
                Description = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium"
            },
            new Department
            {
                Id = 3,
                Name = "Finance",
                Description = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium"
            },
            new Department
            {
                Id = 4,
                Name = "Business",
                Description = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium"
            }
        );
    }
}
