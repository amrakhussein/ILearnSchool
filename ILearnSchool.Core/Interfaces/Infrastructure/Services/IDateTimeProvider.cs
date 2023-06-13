namespace ILearnSchool.Core.Interfaces.Infrastructure.Services;

public interface IDateTimeProvider
{
    DateTime UtcNow { get; }
}
