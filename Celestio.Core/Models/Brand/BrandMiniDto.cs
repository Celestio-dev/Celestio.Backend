using Celestio.Core.Models.Media;

namespace Celestio.Core.Models.Brand;

public class BrandMiniDto
{
    public int Id { get; set; }
    public string BrandName { get; set; }
    public virtual MediaDto ProfilePicMedia { get; set; }
}