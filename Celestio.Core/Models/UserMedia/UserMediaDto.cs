using Celestio.Core.Models.Category;
using Celestio.Core.Models.Media;

namespace Celestio.Core.Models.UserMedia;

public class UserMediaDto
{
    public int Id { get; set; }
    public int MediaId { get; set; }
    public int UserId { get; set; }
    
    public virtual MediaDto Media { get; set; }
    public virtual ICollection<CategoryDto> UserMediaCategories { get; set; }
}