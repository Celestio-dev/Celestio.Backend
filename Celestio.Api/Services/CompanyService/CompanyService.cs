using AutoMapper;
using Celestio.Api.Data;

namespace Celestio.Api.Services.CompanyService;

public class CompanyService : ICompanyService
{
    private readonly DataContext _context;
    private readonly IMapper _mapper;

    public CompanyService(DataContext dbContext, IMapper mapper)
    {
        _context = dbContext;
        _mapper = mapper;
    }
}