using Celestio.Api.Services.CompanyService;
using Microsoft.AspNetCore.Mvc;

namespace Celestio.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CompanyController
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
}