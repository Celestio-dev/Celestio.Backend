using AutoMapper;
using Celestio.Api.Data;

namespace Celestio.Api.Services.MediaService;

public class MediaService : IMediaService
{
    private readonly DataContext _context;
    private readonly IMapper _mapper;

    public MediaService(DataContext dbContext, IMapper mapper)
    {
        _context = dbContext;
        _mapper = mapper;
    }
}