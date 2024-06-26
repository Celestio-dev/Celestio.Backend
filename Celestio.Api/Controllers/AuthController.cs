using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Celestio.Api.Services.AuthService;
using Celestio.Api.Services.UserService;
using Celestio.Core.Enums;
using Celestio.Core.Helpers;
using Celestio.Core.Models.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using Microsoft.IdentityModel.Tokens;

namespace Celestio.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly ILogger _logger;
    private readonly IConfiguration _configuration;
    private readonly IAuthService _authService;
    private readonly IUserService _userService;
    public AuthController(ILogger<UsersController> logger, IConfiguration configuration, IAuthService authService, IUserService userService)
    {
        _logger = logger;
        _configuration = configuration;
        _authService = authService;
        _userService = userService;
    }

    

    [HttpPost("register")]
    [AllowAnonymous]
    public async Task<ActionResult<UserDto>> RegisterUser(RegisterUserDto registerUser)
    {
        await _authService.CreateUser(registerUser);
        return Ok(registerUser);
    }
    
    /// <summary>
    /// Test summary of Login endpoint
    /// </summary>
    /// <param name="login"></param>
    /// <returns></returns>
    [HttpPost("login")]
    [AllowAnonymous]
    public async Task<ActionResult<string>> Login(LoginDto login)
    {
        var user = await _userService.GetUserByEmail(login.Email);
        if (user is null)
            return BadRequest("User not found.");

        var verifyLogin = await _authService.Login(user, login.Password);
        if (!verifyLogin)
            return BadRequest("Wrong credentials.");

        //var account = await _accountService.GetAccount(user.Id);
        //var accountId = account is null ? 0 : account.Id;

        var role = Enum.GetName(typeof(RolesEnum), user.RoleId);
        if (role is null)
            return BadRequest("Role not found.");

        string token = JwtHelper.CreateToken(user, role, _configuration.GetSection("Jwt:Key").Value);
        return Ok(token);
    }
    
    [HttpGet("me")]
    [Authorize]
    public async Task<ActionResult<UserDto>> GetAuthenticatedUser()
    {
        AuthenticatedUser? authUser = UserHelper.GetAuthUserFromClaims(User);
        if (authUser is null) return Unauthorized();

        var user = await _userService.GetUserById(authUser.UserId);
        return Ok(user);
        //throw new NotImplementedException();
    }

    
    
    
}