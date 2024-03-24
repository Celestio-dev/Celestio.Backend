using AutoMapper;
using Celestio.Api.Data;

namespace Celestio.Api.Services.BrandService;

public class BrandService : IBrandService
{
    private readonly DataContext _context;
    private readonly IMapper _mapper;

    public BrandService(DataContext dbContext, IMapper mapper)
    {
        _context = dbContext;
        _mapper = mapper;
    }
}