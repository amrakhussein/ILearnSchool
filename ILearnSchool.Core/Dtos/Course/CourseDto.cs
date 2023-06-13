using IlearnSchool.Core.Dtos.Department;
using IlearnSchool.Core.Dtos.Instructors;

namespace IlearnSchool.Core.Dtos.Course;

public class CourseDto
{
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public double Grade { get; set; }
    public int PassingGrade { get; set; }

    public IEnumerable<InstructorDto> Instructors { get; set; } = null!;
    public DepartmentDto Department { get; set; } = null!;
}