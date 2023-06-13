using ILearnSchool.Core.Interfaces.Infrastructure.Services;

namespace ILearnSchool.Persistence.Services;

public class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}
