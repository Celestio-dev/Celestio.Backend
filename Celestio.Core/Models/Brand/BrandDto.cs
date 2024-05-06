using Celestio.Core.Models.Brief;
using Celestio.Core.Models.Media;
using Celestio.Core.Models.SocialMedia;

namespace Celestio.Core.Models.Brand;

public class BrandDto
{
    public int Id { get; set; }
    public string BrandName { get; set; }
    public string BrandDescription { get; set; }
    //public int ProfilePicMediaId { get; set; }
    
    public DateTime Created { get; set; }
    
    public virtual ICollection<BriefDto> Briefs { get; set; }
    public virtual MediaDto ProfilePicMedia { get; set; }
    public virtual ICollection<SocialMediaDto> SocialMediae { get; set; }
}