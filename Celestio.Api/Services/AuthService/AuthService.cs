using AutoMapper;
using Celestio.Api.Data;
using Celestio.Core.Helpers;
using Celestio.Core.Models.User;

namespace Celestio.Api.Services.AuthService;

public class AuthService : IAuthService
{
    private readonly DataContext _context;
    private readonly IMapper _mapper;

    public AuthService(DataContext dbContext, IMapper mapper)
    {
        _context = dbContext;
        _mapper = mapper;
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