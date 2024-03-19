using AutoMapper;
using Celestio.Api.Data;
using Celestio.Core.Helpers;
using Celestio.Core.Models.User;
using Microsoft.EntityFrameworkCore;

namespace Celestio.Api.Services.UserService;

public class UserService : IUserService
{

    private readonly DataContext _context;
    private readonly IMapper _mapper;

    public UserService(DataContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<IList<UserDto>> GetAllUsers()
    {
        var users = await _context.Users.ToListAsync();
        
        var usersDto = _mapper.Map<List<UserDto>>(users);
        return usersDto;
    }
    
    public async Task<UserDto> GetUserByUsernameOrEmail(string username, string email)
    {
        throw new NotImplementedException();
    }
    
    public async Task<bool> Login(UserDto user, string password)
    {
        var userEntity = await _context.Users.FindAsync(user.Id);
        if (userEntity is not null && UserHelper.VerifyPasswordHash(password, userEntity.PasswordHash, userEntity.PasswordSalt))
        {
            return true;
        }

        return false;
    }
}