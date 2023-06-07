namespace ILearnSchool.Core.Models;

public class Trainee
{
    public int Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public int Age { get; set; }

    public int DepartmentId { get; set; }
    public Department Department { get; set; } = null!;

    public ICollection<CourseResult> CourseResults { get; set; } = null!;
    public ICollection<Enrollment> Enrollments { get; set; } = null!;
}
