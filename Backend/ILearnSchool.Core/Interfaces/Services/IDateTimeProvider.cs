namespace ILearnSchool.Core.Interfaces.Services;

public interface IDateTimeProvider
{
    DateTime UtcNow { get; }
}
