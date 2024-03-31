using Microsoft.AspNetCore.Mvc;

namespace Celestio.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HealthController : ControllerBase
{
    public HealthController()
    {
        
    }

    [HttpGet]
    public string GetHealth()
    {
        return "OK";
    }
}