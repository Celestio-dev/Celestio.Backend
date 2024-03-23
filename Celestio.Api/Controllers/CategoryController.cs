using Celestio.Api.Services.CategoryService;

namespace Celestio.Api.Controllers;

public class CategoryController
{
    private readonly ILogger _logger;
    private readonly IConfiguration _configuration;
    private readonly ICategoryService _categoryService;
    
    public CategoryController(ILogger<CategoryController> logger, IConfiguration configuration, ICategoryService categoryService)
    {
        _logger = logger;
        _configuration = configuration;
        _categoryService = categoryService;
    }
}