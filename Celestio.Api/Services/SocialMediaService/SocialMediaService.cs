using AutoMapper;
using Celestio.Api.Data;

namespace Celestio.Api.Services.SocialMediaService;

public class SocialMediaService : ISocialMediaService
{
    private readonly DataContext _context;
    private readonly IMapper _mapper;

    public SocialMediaService(DataContext dbContext, IMapper mapper)
    {
        _context = dbContext;
        _mapper = mapper;
    }
}