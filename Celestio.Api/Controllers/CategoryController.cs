using Celestio.Api.Data.Entities;
using Celestio.Api.Services.CategoryService;
using Celestio.Core.Enums;
using Celestio.Core.Helpers;
using Microsoft.AspNetCore.Mvc;
using Celestio.Core.Models.Category;
using Microsoft.AspNetCore.Authorization;
using Microsoft.OpenApi.Extensions;

namespace Celestio.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CategoryController : ControllerBase
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


    [HttpGet]
    public async Task<ActionResult<List<CategoryDto>>> GetAllCategories()
    {
        throw new NotImplementedException();
    }
    
    [HttpPost]
    [AuthorizeRole(RolesEnum.SuperAdmin)]
    public async Task<ActionResult<CategoryDto>> CreateCategory()
    {
        throw new NotImplementedException();
    }
    
    [HttpPut]
    [AuthorizeRole(RolesEnum.SuperAdmin)]
    public async Task<ActionResult<CategoryDto>> UpdateCategory()
    {
        throw new NotImplementedException();
    }
}