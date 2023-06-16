using ILearnSchool.Core.Models;
using ILearnSchool.Persistence.Data.SeedConfig.SeedHelper;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ILearnSchool.Persistence.Data.SeedConfig.Entities;

public class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
{
    public void Configure(EntityTypeBuilder<Instructor> builder)
    {
        var random = new Random();
        int instructorCount = 8;

        for (int i = 0; i < instructorCount; i++)
        {
            int randomAge = random.Next(28, 50); // Random age between 28 and 50
            int randomIndex = random.Next(0, PersonNamesDummyData.FirstNames.Length);
            builder.HasData(
                           new Instructor
                           {
                               Id = i + 1, // Starting from ID 1
                               FirstName = PersonNamesDummyData.FirstNames[randomIndex],
                               LastName = PersonNamesDummyData.LastNames[randomIndex],
                               Age = randomAge,
                               DepartmentId = (i % 4) + 1 // Department IDs from 1 to 4
                           }
                );
        }
    }
}
