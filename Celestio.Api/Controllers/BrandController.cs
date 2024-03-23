using Celestio.Api.Services.BrandService;
using Microsoft.AspNetCore.Mvc;

namespace Celestio.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BrandController
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
}