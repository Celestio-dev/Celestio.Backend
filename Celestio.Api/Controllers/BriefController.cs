using Celestio.Api.Services.BriefService;
using Celestio.Core.Enums;
using Celestio.Core.Helpers;
using Celestio.Core.Models.Brief;
using Microsoft.AspNetCore.Authorization;
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
    
    /// <summary>
    /// get all briefs for given brand Id
    /// </summary>
    /// <param name="brandId"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    [HttpGet("brand/{brandId}")]
    public async Task<ActionResult<List<BriefDto>>> GetBriefsByBrandId(int brandId)
    {
        throw new NotImplementedException();
    }
    
    [HttpGet("categories")]
    public async Task<ActionResult<List<BriefDto>>> GetBriefsByCategoryFilter([FromForm] List<int> categoryIds)
    {
        throw new NotImplementedException();
    }
    
    [AuthorizeRole(RolesEnum.AgencyAdmin)]// todo check which roles
    [HttpGet("{id}")]
    public async Task<ActionResult<BriefDto>> GetBriefById()
    {
        throw new NotImplementedException();
    }


    [HttpPost]
    public async Task<ActionResult<BriefDto>> CreateBrief() // TODO finish this
    {
        throw new NotImplementedException();
    }
}