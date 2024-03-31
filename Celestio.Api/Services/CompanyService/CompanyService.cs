using AutoMapper;
using Celestio.Api.Data;
using Celestio.Api.Services.SocialMediaService;
using Celestio.Core.Models.Company;
using Microsoft.EntityFrameworkCore;

namespace Celestio.Api.Services.CompanyService;

public class CompanyService : ICompanyService
{
    private readonly DataContext _context;
    private readonly IMapper _mapper;
    private readonly ISocialMediaService _socialMediaService;

    public CompanyService(DataContext dbContext, IMapper mapper, ISocialMediaService socialMediaService)
    {
        _context = dbContext;
        _mapper = mapper;
        _socialMediaService = socialMediaService;
    }

    public async Task<CompanyDto?> GetCompanyProfileById(int companyId)
    {
        var companyEntity = await _context.Companies.Where(c => c.Id == companyId)
            .Include(c => c.ProfilePicMedia)
            .FirstOrDefaultAsync();
        if (companyEntity is null)
            return null;
        
        companyEntity.SocialMediae = await _socialMediaService.GetSocialMediaEntityList(companyEntity.Id, "Companies");

        var companyDto = _mapper.Map<CompanyDto>(companyEntity);
        return companyDto;
    }
    
    
}