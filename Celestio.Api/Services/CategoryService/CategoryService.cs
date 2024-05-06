using AutoMapper;
using Celestio.Api.Data;
using Celestio.Core.Models.Category;

namespace Celestio.Api.Services.CategoryService;

public class CategoryService : ICategoryService
{
    private readonly DataContext _context;
    private readonly IMapper _mapper;

    public CategoryService(DataContext dbContext, IMapper mapper)
    {
        _context = dbContext;
        _mapper = mapper;
    }

    public async Task<List<CategoryDto>> GetAllCategories()
    {
        throw new NotImplementedException();
    }

    public async Task<CategoryDto> CreateCategory()
    {
        throw new NotImplementedException();
    }

    public async Task<CategoryDto> UpdateCategory()
    {
        throw new NotImplementedException();
    }
}