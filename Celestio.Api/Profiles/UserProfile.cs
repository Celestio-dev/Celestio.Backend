using AutoMapper;
using Celestio.Api.Data.Entities;
using Celestio.Core.Models.User;

namespace Celestio.Api.Profiles;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<User, UserDto>();
        CreateMap<UserDto, User>();
    }
}