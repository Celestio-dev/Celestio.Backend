using Celestio.Core.Models.User;

namespace Celestio.Api.Services.AuthService;

public interface IAuthService
{
    Task<RegisterUserDto> CreateUser(RegisterUserDto registerUser);
    Task<bool> Login(UserDto user, string password);
}