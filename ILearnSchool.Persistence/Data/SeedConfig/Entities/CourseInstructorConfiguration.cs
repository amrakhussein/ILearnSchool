using ILearnSchool.Core.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ILearnSchool.Persistence.Data.SeedConfig.Entities;

public class CourseInstructorConfiguration : IEntityTypeConfiguration<CourseInstructor>
{
    /// <summary>
    /// Instructor has random course data seeded where course can belong to more than one instructor for intial testing purposes
    /// </summary>
    public void Configure(EntityTypeBuilder<CourseInstructor> builder)
    {
        int maxCoursesPerInstructor = 2;
        int instructorCount = 8; // Seeding up to 8 instructors
        int courseId = 1;
        int courseLimit = 16; // Seeding up to 16 courses


        for (int instructorId = 1; instructorId <= instructorCount; instructorId++)
        {
            for (int courseCount = 1; courseCount <= maxCoursesPerInstructor; courseCount++)
            {
                if (courseId > courseLimit) break;

                builder.HasData(new CourseInstructor
                {
                    InstructorId = instructorId,
                    CourseId = courseId
                });

                courseId++;
            }
        }
    }
}