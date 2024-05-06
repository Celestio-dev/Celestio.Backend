using AutoMapper;
using Celestio.Api.Data;

namespace Celestio.Api.Services.BriefService;

public class BriefService : IBriefService
{
    private readonly DataContext _context;
    private readonly IMapper _mapper;

    public BriefService(DataContext dbContext, IMapper mapper)
    {
        _context = dbContext;
        _mapper = mapper;
    }
}