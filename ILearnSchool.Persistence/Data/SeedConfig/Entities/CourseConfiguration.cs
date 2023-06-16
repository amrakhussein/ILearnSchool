using ILearnSchool.Core.Models;
using ILearnSchool.Persistence.Data.SeedConfig.SeedHelper;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ILearnSchool.Persistence.Data.SeedConfig.Entities;

public class CourseConfiguration : IEntityTypeConfiguration<Course>
{
    public void Configure(EntityTypeBuilder<Course> builder)
    {
        var random = new Random();
        var courseCountLimit = 16;

        for (int i = 0; i < courseCountLimit; i++)
        {
            int randomDescriptionIdx = random.Next(0, CourseDummyData.Descriptions.Length);
            int randomPassingGradeIdx = random.Next(0, CourseDummyData.PassingGrades.Length);

            builder.HasData(
                new Course
                {
                    Id = i + 1, // Starting from ID 1
                    Name = $"Course {i + 1}",
                    Description = CourseDummyData.Descriptions[randomDescriptionIdx],
                    PassingGrade = CourseDummyData.PassingGrades[randomPassingGradeIdx],
                    DepartmentId = (i % 4) + 1 // Department IDs from 1 to 4
                });
        }
    }
}
