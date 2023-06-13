using IlearnSchool.Core.Dtos.Course;
using IlearnSchool.Core.Dtos.Instructors;
using IlearnSchool.Core.Dtos.Trainees;

namespace IlearnSchool.Core.Dtos.Department;

public class DepartmentDetailDto
{
    public string Name { get; set; } = null!;
    public string? Description { get; set; } = null!;

    public IEnumerable<InstructorDto> Instructors { get; set; } = null!;
    public IEnumerable<CourseDto> Courses { get; set; } = null!;
    public IEnumerable<TraineeWithResultsDto> Trainees { get; set; } = null!;
}