using Celestio.Core.Models.Category;

namespace Celestio.Api.Services.CategoryService;

public interface ICategoryService
{
    Task<List<CategoryDto>> GetAllCategories();
    Task<CategoryDto> CreateCategory();
    Task<CategoryDto> UpdateCategory();
}