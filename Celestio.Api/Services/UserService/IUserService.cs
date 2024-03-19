using Celestio.Core.Models.User;

namespace Celestio.Api.Services.UserService;

public interface IUserService
{
    Task<IList<UserDto>> GetAllUsers();
    Task<UserDto> GetUserByUsernameOrEmail(string username, string email);
    Task<bool> Login(UserDto user, string password);

}