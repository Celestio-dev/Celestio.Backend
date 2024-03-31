using AutoMapper;
using Celestio.Api.Data.Entities;
using Celestio.Core.Models.SocialMedia;

namespace Celestio.Api.Profiles;

public class SocialMediaProfile : Profile
{
    public SocialMediaProfile()
    {
        CreateMap<SocialMedia, SocialMediaDto>();
        CreateMap<SocialMediaDto, SocialMedia>();
    }
}