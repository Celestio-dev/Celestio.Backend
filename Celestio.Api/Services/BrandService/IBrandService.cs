using Celestio.Core.Models.Brand;

namespace Celestio.Api.Services.BrandService;

public interface IBrandService
{
    Task<BrandDto?> GetBrandProfileById(int brandId);
    
    Task<List<BrandDto>?> GetBrandsByCompanyId(int companyId);
    Task<List<BrandMiniDto>?> GetBrandsDropdownByCompanyId(int companyId);
}