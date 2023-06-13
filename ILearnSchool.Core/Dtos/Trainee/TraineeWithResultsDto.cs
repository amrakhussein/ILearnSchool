using IlearnSchool.Core.Dtos.CourseResults;

namespace IlearnSchool.Core.Dtos.Trainees;

public class TraineeWithResultsDto
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public int Age { get; set; }

    public IEnumerable<CourseResultDto> CourseResults { get; set; } = null!;
}
