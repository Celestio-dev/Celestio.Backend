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

    public UserService(DataContext dbContext, IMapper mapper)
    {
        _context = dbContext;
        _mapper = mapper;
    }

    public async Task<IList<UserDto>> GetAllUsers()
    {
        var users = await _context.Users.ToListAsync();

        var usersDto = _mapper.Map<List<UserDto>>(users);
        return usersDto;
    }
    
    public async Task<UserDto> GetUserByEmail(string email)
    {
        throw new NotImplementedException();
    }
    
    
}