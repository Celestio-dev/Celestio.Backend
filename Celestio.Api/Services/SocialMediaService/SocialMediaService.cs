using AutoMapper;
using Celestio.Api.Data;
using Celestio.Api.Data.Entities;
using Celestio.Core.Enums;
using Celestio.Core.Helpers;
using Celestio.Core.Models.SocialMedia;
using Microsoft.EntityFrameworkCore;

namespace Celestio.Api.Services.SocialMediaService;

public class SocialMediaService : ISocialMediaService
{
    private readonly DataContext _context;
    private readonly IMapper _mapper;

    public SocialMediaService(DataContext dbContext, IMapper mapper)
    {
        _context = dbContext;
        _mapper = mapper;
    }

    public async Task<List<SocialMedia>> GetSocialMediaEntityList(int docId, string tableName)
    {
        var socialMediaContext = _context.SocialMediae.Where(s => s.TableName == tableName);
        var socialMediaEntities = await socialMediaContext.Where(s => s.DocId == docId)
            .ToListAsync();

        return socialMediaEntities;
    }

    public async Task<List<SocialMediaDto>> AddUserSocialMedia(List<CreateSocialMediaDto> createSocialList, AuthenticatedUser authUser)
    {
        // check if user allowed
        var socialMediaDtos = await AddSocialMedia(createSocialList, authUser.UserId, "Users");
        return socialMediaDtos;
    }
    public async Task<List<SocialMediaDto>> AddCompanySocialMedia(List<CreateSocialMediaDto> createSocialList, int companyId, AuthenticatedUser authUser)
    {
        // check if user allowed
        if (authUser.Role == RolesEnum.AgencyAdmin && authUser.CompanyId != companyId)
            return null;
        if(authUser.Role != RolesEnum.AgencyAdmin && authUser.Role != RolesEnum.SuperAdmin)
            return null;

        var socialMediaDtos = await AddSocialMedia(createSocialList, companyId, "Companies");
        return socialMediaDtos;
    }
    
    public async Task<List<SocialMediaDto>> AddBrandSocialMedia(List<CreateSocialMediaDto> createSocialList, int brandId, AuthenticatedUser authUser)
    {
        // check if user allowed
        throw new NotImplementedException();

        var socialMediaDtos = await AddSocialMedia(createSocialList, brandId, "Brands");
        return socialMediaDtos;
    }

    private async Task<List<SocialMediaDto>> AddSocialMedia(List<CreateSocialMediaDto> createSocialList, int accountId, string tableName)
    {
        List<SocialMedia> socialMediaEntityList = _mapper.Map<List<SocialMedia>>(createSocialList);
        foreach (var socialMediaEntity in socialMediaEntityList)
        {
            socialMediaEntity.DocId = accountId;
            socialMediaEntity.TableName = tableName;

            _context.Add(socialMediaEntity);
        }

        await _context.SaveChangesAsync();

        var socialMediaDtos = _mapper.Map<List<SocialMediaDto>>(socialMediaEntityList);
        return socialMediaDtos;

    }
}