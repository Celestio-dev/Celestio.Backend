using Celestio.Api.Services.UserService;
using Celestio.Core.Models.Category;
using Celestio.Core.Models.User;
using Celestio.Core.Models.UserMedia;
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

    /// <summary>
    /// Update Creator/User profile (add img, social media, etc)
    /// </summary>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    [Authorize]
    [HttpPost]
    public async Task<ActionResult<UserDto>> UpdateUser()
    {
        throw new NotImplementedException();
    } 
    
    
    [Authorize]
    [HttpPost("upload")]
    public async Task<ActionResult<UserDto>> UploadUserMedia([FromForm] IFormFile file, List<int> categoryIds)
    {
        // get auth user, send to media service, send to usermedia service with user and media info
        throw new NotImplementedException();
    }

    [Authorize]
    [HttpGet("{userId}")]
    public async Task<ActionResult<List<UserMediaDto>>> GetUserMediaListByUserId(int userId)
    {
        throw new NotImplementedException();
    }
    
    

    
    
    
    
    
}