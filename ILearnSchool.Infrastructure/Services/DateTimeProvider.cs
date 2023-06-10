using ILearnSchool.Core.Interfaces.Services;

namespace ILearnSchool.Persistence.Services;

public class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}
