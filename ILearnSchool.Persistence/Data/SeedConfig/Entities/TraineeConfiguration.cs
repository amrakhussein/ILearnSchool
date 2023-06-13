using ILearnSchool.Core.Models;
using ILearnSchool.Persistence.Data.SeedConfig.SeedHelper;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ILearnSchool.Persistence.Data.SeedConfig.Entities;

public class TraineeConfiguration : IEntityTypeConfiguration<Trainee>
{
    public void Configure(EntityTypeBuilder<Trainee> builder)
    {
        var random = new Random();

        for (int i = 0; i < 20; i++)
        {
            int randomAge = random.Next(18, 40); // Random age between 18 and 40
            int randomIndex = random.Next(0, PersonNamesDummyData.FirstNames.Length);
            builder.HasData(
                           new Trainee
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
