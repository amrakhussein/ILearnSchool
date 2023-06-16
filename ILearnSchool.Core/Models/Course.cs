namespace ILearnSchool.Core.Models;

public class Course
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public int MaxGrade { get; set; } = 100;
    public int PassingGrade { get; set; }
    public string? Description { get; set; } = null!;

    public int DepartmentId { get; set; }
    public Department Department { get; set; } = null!;

    public ICollection<CourseInstructor> CourseInstructors { get; set; } = null!;
    public ICollection<Enrollment> Enrollments { get; set; } = null!;
}
