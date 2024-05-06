using Celestio.Api.Services.BrandService;
using Celestio.Core.Enums;
using Celestio.Core.Helpers;
using Celestio.Core.Models.Brand;
using Microsoft.AspNetCore.Mvc;

namespace Celestio.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BrandController : ControllerBase
{
    private readonly ILogger _logger;
    private readonly IConfiguration _configuration;
    private readonly IBrandService _brandService;
    
    public BrandController(ILogger<BrandController> logger, IConfiguration configuration, IBrandService brandService)
    {
        _logger = logger;
        _configuration = configuration;
        _brandService = brandService;
    }
    
    /// <summary>
    /// Brand profile page
    /// </summary>
    /// <param name="brandId"></param>
    /// <returns></returns>
    [HttpGet("{brandId}")]
    public async Task<ActionResult<BrandDto>> GetBrandProfileById(int brandId)
    {
        var brand = await _brandService.GetBrandProfileById(brandId);
        if (brand is null)
        {
            return NotFound("brand not found");
        }
        return Ok(brand);
    }
    
    /// <summary>
    /// Get all brands for given agency/company Id
    /// </summary>
    /// <param name="companyId"></param>
    /// <returns></returns>
    [HttpGet("company/{companyId}")]
    // this return type should be some BrandCardDto or something
    public async Task<ActionResult<List<BrandDto>>> GetBrandsByCompanyId(int companyId)
    {
        var brands = await _brandService.GetBrandsByCompanyId(companyId);
        return Ok(brands);
    }

    /// <summary>
    /// Get brands for navbar dropdown for Agency Admin.
    /// </summary>
    /// <returns></returns>
    [AuthorizeRole(RolesEnum.AgencyAdmin)]
    [HttpGet("dropdown")]
    public async Task<ActionResult<List<BrandMiniDto>>> GetBrandsDropdown()
    {
        AuthenticatedUser? authUser = UserHelper.GetAuthUserFromClaims(User);
        if (authUser is null) return Unauthorized();
        
        var brands = await _brandService.GetBrandsDropdownByCompanyId(authUser.CompanyId);
        return Ok(brands);
    }


    /// <summary>
    /// create brand for agency admin
    /// </summary>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    [AuthorizeRole(RolesEnum.AgencyAdmin)]
    [HttpPost]
    public async Task<ActionResult<BrandDto>> CreateBrandForAgencyAdmin(CreateBrandDto createBrandDto, IFormFile profilePic)
    {
        // check authuser companyid
        throw new NotImplementedException();
    }
    
    /// <summary>
    /// post for superdmin
    /// </summary>
    /// <param name="companyId"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    [AuthorizeRole(RolesEnum.SuperAdmin)]
    [HttpPost("{companyId}")]
    public async Task<ActionResult<BrandDto>> CreateBrandForSuperAdmin([FromForm] CreateBrandDto createBrandDto, IFormFile profilePic, int companyId)
    {
        throw new NotImplementedException();
    }
}