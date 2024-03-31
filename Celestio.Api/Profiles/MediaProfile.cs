using AutoMapper;
using Celestio.Api.Data.Entities;
using Celestio.Core.Models.Media;
using Celestio.Core.Models.SocialMedia;

namespace Celestio.Api.Profiles;

public class MediaProfile : Profile
{
    public MediaProfile()
    {
        CreateMap<Media, MediaDto>();
        CreateMap<MediaDto, Media>();

        CreateMap<CreateSocialMediaDto, SocialMedia>();
    }
}