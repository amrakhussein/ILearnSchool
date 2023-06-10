using ILearnSchool.Core.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ILearnSchool.Persistence.Data.SeedConfig.Entities;

public class CourseResultConfiguration : IEntityTypeConfiguration<CourseResult>
{
    public void Configure(EntityTypeBuilder<CourseResult> builder)
    {
        builder.HasData(
           new CourseResult { Id = 1, Grade = 85, CourseId = 1, TraineeId = 1 },
           new CourseResult { Id = 2, Grade = 77, CourseId = 2, TraineeId = 2 },
           new CourseResult { Id = 3, Grade = 92, CourseId = 3, TraineeId = 2 },
           new CourseResult { Id = 4, Grade = 80, CourseId = 4, TraineeId = 3 },
           new CourseResult { Id = 5, Grade = 88, CourseId = 5, TraineeId = 1 },
           new CourseResult { Id = 6, Grade = 90, CourseId = 6, TraineeId = 2 },
           new CourseResult { Id = 7, Grade = 78, CourseId = 7, TraineeId = 3 },
           new CourseResult { Id = 8, Grade = 95, CourseId = 8, TraineeId = 4 },
           new CourseResult { Id = 9, Grade = 83, CourseId = 9, TraineeId = 1 },
           new CourseResult { Id = 10, Grade = 92, CourseId = 10, TraineeId = 2 },
           new CourseResult { Id = 11, Grade = 88, CourseId = 11, TraineeId = 3 },
           new CourseResult { Id = 12, Grade = 75, CourseId = 12, TraineeId = 4 },
           new CourseResult { Id = 13, Grade = 85, CourseId = 13, TraineeId = 1 },
           new CourseResult { Id = 14, Grade = 79, CourseId = 14, TraineeId = 2 },
           new CourseResult { Id = 15, Grade = 93, CourseId = 15, TraineeId = 3 },
           new CourseResult { Id = 16, Grade = 87, CourseId = 16, TraineeId = 4 },

           new CourseResult { Id = 17, Grade = 87, CourseId = 1, TraineeId = 4 },
           new CourseResult { Id = 18, Grade = 83, CourseId = 1, TraineeId = 3 },
           new CourseResult { Id = 19, Grade = 82, CourseId = 1, TraineeId = 2 }
       );
    }
}