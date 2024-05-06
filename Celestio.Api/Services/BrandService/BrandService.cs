using AutoMapper;
using Celestio.Api.Data;
using Celestio.Api.Services.SocialMediaService;
using Celestio.Core.Models.Brand;
using Microsoft.EntityFrameworkCore;

namespace Celestio.Api.Services.BrandService;

public class BrandService : IBrandService
{
    private readonly DataContext _context;
    private readonly IMapper _mapper;
    private readonly ISocialMediaService _socialMediaService;

    public BrandService(DataContext dbContext, IMapper mapper, ISocialMediaService socialMediaService)
    {
        _context = dbContext;
        _mapper = mapper;
        _socialMediaService = socialMediaService;
    }

    public async Task<BrandDto?> GetBrandProfileById(int brandId)
    {
        var brandEntity = await _context.Brands.Where(c => c.Id == brandId)
            .Include(c => c.ProfilePicMedia)
            .FirstOrDefaultAsync();

        if (brandEntity is null)
            return null;
        
        brandEntity.SocialMediae = await _socialMediaService.GetSocialMediaEntityList(brandEntity.Id, "Brands");

        var brandDto = _mapper.Map<BrandDto?>(brandEntity);
        return brandDto;
    }

    public async Task<List<BrandDto>?> GetBrandsByCompanyId(int companyId)
    {
        throw new NotImplementedException();
    }

    public async Task<List<BrandMiniDto>?> GetBrandsDropdownByCompanyId(int companyId)
    {
        throw new NotImplementedException();
    }
}