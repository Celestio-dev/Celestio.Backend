using AutoMapper;
using Celestio.Api.Data;
using Celestio.Core.Enums;
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


    public async Task<RegisterUserDto> CreateUser(RegisterUserDto registerUser)
    {
        var userEntity = _mapper.Map<Data.Entities.User>(registerUser);
        UserHelper.CreatePasswordHash(registerUser.Password, out byte[] passwordHash, out byte[] passwordSalt);
        userEntity.PasswordHash = passwordHash;
        userEntity.PasswordSalt = passwordSalt;

        userEntity.RoleId = (int) RolesEnum.User;
        userEntity.CompanyId = 1;
        
        _context.Users.Add(userEntity);
        await _context.SaveChangesAsync();

        
        await _context.SaveChangesAsync();

        return registerUser;
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