using AutoMapper;
using Celestio.Api.Data;

namespace Celestio.Api.Services.UserMediaService;

public class UserMediaService : IUserMediaService
{
    private readonly DataContext _context;
    private readonly IMapper _mapper;
    
    public UserMediaService(DataContext dbContext, IMapper mapper)
    {
        _context = dbContext;
        _mapper = mapper;
    }
}