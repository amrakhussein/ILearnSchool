namespace IlearnSchool.Core.Dtos.Authentication;

public record AuthenticatedUserResponseDto(string Email,
                                           string FirstName,
                                           string LastName,
                                           string Token);
