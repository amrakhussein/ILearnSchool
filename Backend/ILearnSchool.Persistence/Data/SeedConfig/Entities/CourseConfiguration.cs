using ILearnSchool.Core.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ILearnSchool.Persistence.Data.SeedConfig.Entities;

public class CourseConfiguration : IEntityTypeConfiguration<Course>
{
    public void Configure(EntityTypeBuilder<Course> builder)
    {
        builder.HasData(
          // seed related courses for compu sci department
          new Course { Id = 1, Name = "Java", Description = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.", Grade = 90, PassingGrade = 60, DepartmentId = 1 },
          new Course { Id = 2, Name = "OOP", Description = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.", Grade = 80, PassingGrade = 60, DepartmentId = 1 },
          new Course { Id = 3, Name = "Networks", Description = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.", Grade = 75, PassingGrade = 60, DepartmentId = 1 },
          new Course { Id = 4, Name = "Data Structure", Description = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.", Grade = 79, PassingGrade = 60, DepartmentId = 1 },

          // seed related courses for Arts department
          new Course { Id = 5, Name = "History of Art 1", Description = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.", Grade = 50, PassingGrade = 70, DepartmentId = 2 },
          new Course { Id = 6, Name = "History of Art 2", Description = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.", Grade = 80, PassingGrade = 70, DepartmentId = 2 },
          new Course { Id = 7, Name = "Art Movements", Description = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.", Grade = 60, PassingGrade = 50, DepartmentId = 2 },
          new Course { Id = 8, Name = "Art Appreciation", Description = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.", Grade = 40, PassingGrade = 50, DepartmentId = 2 },

          // seed related courses for Finance department
          new Course { Id = 9, Name = "Corporate Finance", Description = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.", Grade = 90, PassingGrade = 60, DepartmentId = 3 },
          new Course { Id = 10, Name = "Financial Risk Management", Description = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.", Grade = 80, PassingGrade = 60, DepartmentId = 3 },
          new Course { Id = 11, Name = "Investment Analysis", Description = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.", Grade = 75, PassingGrade = 60, DepartmentId = 3 },
          new Course { Id = 12, Name = "Managerial Finance", Description = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.", Grade = 79, PassingGrade = 60, DepartmentId = 3 },

          // seed related courses for Business department
          new Course { Id = 13, Name = "Principles of Marketing", Description = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.", Grade = 90, PassingGrade = 60, DepartmentId = 4 },
          new Course { Id = 14, Name = "Entrepreneurship", Description = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.", Grade = 80, PassingGrade = 60, DepartmentId = 4 },
          new Course { Id = 15, Name = "Customer Psychology", Description = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.", Grade = 75, PassingGrade = 60, DepartmentId = 4 },
          new Course { Id = 16, Name = "The Art of Business", Description = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.", Grade = 79, PassingGrade = 60, DepartmentId = 4 }
      );
    }
}
