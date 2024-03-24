using Celestio.Core.Models.User;

namespace Celestio.Api.Services.UserService;

public interface IUserService
{
    Task<IList<UserDto>> GetAllUsers();
    Task<UserDto> GetUserByEmail(string email);
    

}