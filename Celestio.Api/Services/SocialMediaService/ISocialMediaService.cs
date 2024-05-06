using Celestio.Api.Data.Entities;
using Celestio.Core.Helpers;
using Celestio.Core.Models.SocialMedia;

namespace Celestio.Api.Services.SocialMediaService;

public interface ISocialMediaService
{
    Task<List<SocialMedia>> GetSocialMediaEntityList(int docId, string tableName);

    Task<List<SocialMediaDto>> AddUserSocialMedia(List<CreateSocialMediaDto> createSocialList,
        AuthenticatedUser authUser);

    Task<List<SocialMediaDto>> AddCompanySocialMedia(List<CreateSocialMediaDto> createSocialList, int companyId,
        AuthenticatedUser authUser);

    Task<List<SocialMediaDto>> AddBrandSocialMedia(List<CreateSocialMediaDto> createSocialList, int brandId,
        AuthenticatedUser authUser);
}