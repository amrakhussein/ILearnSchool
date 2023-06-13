namespace IlearnSchool.Core.Dtos.CourseResults;

public class CourseResultDto
{
    public int Id { get; set; }
    public double Grade { get; set; }

    public int CourseId { get; set; }
    public int TraineeId { get; set; }
}
