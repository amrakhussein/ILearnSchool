using ILearnSchool.Core.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ILearnSchool.Persistence.Data.SeedConfig.Entities;

public class CourseEnrollmentConfiguration : IEntityTypeConfiguration<Enrollment>
{
    public void Configure(EntityTypeBuilder<Enrollment> builder)
    {
        builder.HasData(
             new Enrollment { Id = 1, Grade = 60, TraineeId = 1, CourseId = 1 },
                     new Enrollment { Id = 2, Grade = 50, TraineeId = 2, CourseId = 2 },
                     new Enrollment { Id = 3, Grade = 40, TraineeId = 3, CourseId = 3 },
                     new Enrollment { Id = 4, Grade = 30, TraineeId = 4, CourseId = 4 },
                     new Enrollment { Id = 5, Grade = 77, TraineeId = 1, CourseId = 5 },
                     new Enrollment { Id = 6, Grade = 80, TraineeId = 2, CourseId = 6 },
                     new Enrollment { Id = 7, Grade = 90, TraineeId = 3, CourseId = 7 },
                     new Enrollment { Id = 8, Grade = 100, TraineeId = 4, CourseId = 8 },
                     new Enrollment { Id = 9, Grade = 86.3, TraineeId = 1, CourseId = 9 },
                     new Enrollment { Id = 10, Grade = 67.7, TraineeId = 2, CourseId = 10 },
                     new Enrollment { Id = 11, Grade = 97.5, TraineeId = 3, CourseId = 11 },
                     new Enrollment { Id = 12, Grade = 67, TraineeId = 4, CourseId = 12 },
                     new Enrollment { Id = 13, Grade = 88, TraineeId = 1, CourseId = 13 },
                     new Enrollment { Id = 14, Grade = 76, TraineeId = 2, CourseId = 14 },
                     new Enrollment { Id = 15, Grade = 65, TraineeId = 3, CourseId = 15 },
                     new Enrollment { Id = 16, Grade = 78.6, TraineeId = 4, CourseId = 16 },

                      new Enrollment { Id = 17, Grade = 55, TraineeId = 2, CourseId = 1 },
                         new Enrollment { Id = 18, Grade = 86, TraineeId = 3, CourseId = 1 },
                         new Enrollment { Id = 19, Grade = 76.8, TraineeId = 4, CourseId = 1 },

                         new Enrollment { Id = 20, Grade = 76.8, TraineeId = 5, CourseId = 12 },
                         new Enrollment { Id = 21, Grade = 76.8, TraineeId = 6, CourseId = 13 },
                         new Enrollment { Id = 22, Grade = 76.8, TraineeId = 7, CourseId = 14 },
                         new Enrollment { Id = 23, Grade = 76.8, TraineeId = 8, CourseId = 3 },
                         new Enrollment { Id = 24, Grade = 76.8, TraineeId = 9, CourseId = 1 },
                         new Enrollment { Id = 25, Grade = 76.8, TraineeId = 10, CourseId = 2 }
             );
    }
}
