using Celestio.Api.Services.BrandService;
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
}