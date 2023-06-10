using ILearnSchool.Core.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ILearnSchool.Persistence.Data.SeedConfig.Entities;

public class EnrollmentConfiguration : IEntityTypeConfiguration<Enrollment>
{
    public void Configure(EntityTypeBuilder<Enrollment> builder)
    {
        builder.HasData(
             new Enrollment { Id = 1, HasEnrolled = true, TraineeId = 1, CourseId = 1 },
                     new Enrollment { Id = 2, HasEnrolled = true, TraineeId = 2, CourseId = 2 },
                     new Enrollment { Id = 3, HasEnrolled = true, TraineeId = 3, CourseId = 3 },
                     new Enrollment { Id = 4, HasEnrolled = true, TraineeId = 4, CourseId = 4 },
                     new Enrollment { Id = 5, HasEnrolled = true, TraineeId = 1, CourseId = 5 },
                     new Enrollment { Id = 6, HasEnrolled = true, TraineeId = 2, CourseId = 6 },
                     new Enrollment { Id = 7, HasEnrolled = true, TraineeId = 3, CourseId = 7 },
                     new Enrollment { Id = 8, HasEnrolled = true, TraineeId = 4, CourseId = 8 },
                     new Enrollment { Id = 9, HasEnrolled = true, TraineeId = 1, CourseId = 9 },
                     new Enrollment { Id = 10, HasEnrolled = true, TraineeId = 2, CourseId = 10 },
                     new Enrollment { Id = 11, HasEnrolled = true, TraineeId = 3, CourseId = 11 },
                     new Enrollment { Id = 12, HasEnrolled = true, TraineeId = 4, CourseId = 12 },
                     new Enrollment { Id = 13, HasEnrolled = true, TraineeId = 1, CourseId = 13 },
                     new Enrollment { Id = 14, HasEnrolled = true, TraineeId = 2, CourseId = 14 },
                     new Enrollment { Id = 15, HasEnrolled = true, TraineeId = 3, CourseId = 15 },
                     new Enrollment { Id = 16, HasEnrolled = true, TraineeId = 4, CourseId = 16 },

                      new Enrollment { Id = 17, HasEnrolled = true, TraineeId = 2, CourseId = 1 },
                         new Enrollment { Id = 18, HasEnrolled = true, TraineeId = 3, CourseId = 1 },
                         new Enrollment { Id = 19, HasEnrolled = true, TraineeId = 4, CourseId = 1 }
             );
    }
}
