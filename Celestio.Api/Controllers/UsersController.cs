using Celestio.Api.Services.UserService;
using Celestio.Core.Models.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Celestio.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    private readonly ILogger _logger;
    private readonly IConfiguration _configuration;
    private readonly IUserService _userService;
    public UsersController(ILogger<UsersController> logger, IConfiguration configuration, IUserService userService)
    {
        _logger = logger;
        _configuration = configuration;
        _userService = userService;
    }
    
    
    [HttpGet("all")]
    public async Task<ActionResult<UserDto>> GetAllUsers()
    {
        var users = await _userService.GetAllUsers();
        return Ok(users);
        //throw new NotImplementedException();
    }

    
    
    
    
    
}