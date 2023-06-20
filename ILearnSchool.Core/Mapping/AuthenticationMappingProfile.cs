using AutoMapper;

using IlearnSchool.Core.Dtos.Authentication;

using ILearnSchool.Core.Dtos.Authentication;
using ILearnSchool.Core.Features.Authentication.Commands.Register;
using ILearnSchool.Core.Features.Authentication.Queries.Login;
using ILearnSchool.Core.Models;

namespace IlearnSchool.Core.Mapping;

public class AuthenticationMappingProfile : Profile
{
    public AuthenticationMappingProfile()
    {
        // Register
        CreateMap<RegisterUserDto, RegisterCommand>();
        //CreateMap<RefreshToken, RefreshTokenDto>().ForCtorParam(nameof(RefreshTokenDto.RefreshToken),
        //                                                     opt => opt.MapFrom(src => src.Token));

        CreateMap<RefreshToken, RefreshTokenDto>().ForMember(dest => dest.RefreshToken,
                                                           opt => opt.MapFrom(src => src.Token));

        CreateMap<ApplicationUser, AuthenticatedUserResponseDto>();

        // Login
        CreateMap<LoginUserDto, LoginQuery>();

    }
}

