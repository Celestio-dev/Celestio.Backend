using Celestio.Api.Services.CompanyService;
using Celestio.Core.Models.Company;
//using Microsoft.AspNetCore.Http.HttpResults;
//using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Celestio.Api.Controllers;


[Route("api/[controller]")]
[ApiController]
public class CompanyController : ControllerBase
{
    private readonly ILogger _logger;
    private readonly IConfiguration _configuration;
    private readonly ICompanyService _companyService;
    
    public CompanyController(ILogger<CompanyController> logger, IConfiguration configuration, ICompanyService companyService)
    {
        _logger = logger;
        _configuration = configuration;
        _companyService = companyService;
    }
    /// <summary>
    /// Agency/company profile page
    /// </summary>
    /// <param name="companyId"></param>
    /// <returns></returns>
    [HttpGet("{companyId}")]
    public async Task<ActionResult<CompanyDto>> GetCompanyProfileById(int companyId)
    {
        var company = await _companyService.GetCompanyProfileById(companyId);
        if (company is null)
        {
            return NotFound("company not found");
        }
        return Ok(company);
    }
}