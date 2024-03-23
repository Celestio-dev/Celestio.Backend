using Celestio.Api.Services.BriefService;
using Celestio.Core.Models.Brief;
using Microsoft.AspNetCore.Mvc;

namespace Celestio.Api.Controllers;


[Route("api/[controller]")]
[ApiController]
public class BriefController : ControllerBase
{
    private readonly ILogger _logger;
    private readonly IConfiguration _configuration;
    private readonly IBriefService _briefService;
    
    public BriefController(ILogger<BriefController> logger, IConfiguration configuration, IBriefService briefService)
    {
        _logger = logger;
        _configuration = configuration;
        _briefService = briefService;
    }

    [HttpGet("all")]
    public async Task<ActionResult<List<BriefDto>>> GetAllBriefs()
    {
        throw new NotImplementedException();
    }
    
    [HttpGet("brand/{brandId}")]
    public async Task<ActionResult<BriefDto>> GetBriefsByBrandId(int brandId)
    {
        throw new NotImplementedException();
    }
    
    [HttpGet("categories")]
    public async Task<ActionResult<List<BriefDto>>> GetBriefsByCategoryFilter()
    {
        throw new NotImplementedException();
    }
}