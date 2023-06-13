using ErrorOr;

using IlearnSchool.Core.Dtos.Authentication;

using ILearnSchool.Core.Features.Authentication.Common;

using Mapster;

namespace IlearnSchool.Api.Mapping;

public class AuthenticationMappingConfig : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<ErrorOr<AuthenticationResult>, UserResponseDto>()
            .Map(dest => dest.Token, src => src.Value.Token)
        //.Map(dest => dest.Email, src => src.Value.User.Email)
        //.Map(dest => dest.FirstName, src => src.Value.User.FirstName)
        //.Map(dest => dest.LastName, src => src.Value.User.LastName);
        .Map(dest => dest, src => src.Value.User);
    }
}