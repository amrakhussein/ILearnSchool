using IlearnSchool.Core.Dtos.Course;
using IlearnSchool.Core.Dtos.Department;

namespace IlearnSchool.Core.Dtos.Instructors;

public class InstructorDetailsDto
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public int Age { get; set; }

    public DepartmentDto Department { get; set; } = null!;
    public IEnumerable<CourseDto> Courses { get; set; } = null!;
}
