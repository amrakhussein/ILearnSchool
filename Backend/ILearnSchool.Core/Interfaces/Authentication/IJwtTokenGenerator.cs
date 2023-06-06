namespace ILearnSchool.Core.Interfaces.Authentication
{
    public interface IJwtTokenGenerator
    {
        string GenerateJwtToken(Guid userId,
                                string firstName,
                                string lastName);
    }
}
