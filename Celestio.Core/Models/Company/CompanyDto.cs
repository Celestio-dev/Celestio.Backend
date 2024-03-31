using Celestio.Core.Enums;
using Celestio.Core.Models.Media;
using Celestio.Core.Models.SocialMedia;

namespace Celestio.Core.Models.Company;

public class CompanyDto
{
    public int Id { get; set; }
    public string CompanyName { get; set; }
    public string CompanyDescription { get; set; }
    public CompanyType Type { get; set; }
    public string ContactEmail { get; set; }
    public int ProfilePicMediaId { get; set; }
    public DateTime Created { get; set; }
    
    public virtual MediaDto ProfilePicMedia { get; set; }
    //public virtual ICollection<UserDto> Users { get; set; }
    public virtual ICollection<SocialMediaDto> SocialMediae { get; set; }
}