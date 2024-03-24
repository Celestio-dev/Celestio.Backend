using Celestio.Core.Enums;

namespace Celestio.Api.Data.Entities;

public class Company
{
    public int Id { get; set; }
    public string CompanyName { get; set; }
    public string CompanyDescription { get; set; }
    public CompanyType Type { get; set; }
    public string ContactEmail { get; set; }
    public int ProfilePicMediaId { get; set; }
    public DateTime Created { get; set; }
    
    public virtual Media ProfilePicMedia { get; set; }
    public virtual ICollection<User> Users { get; set; }
    public virtual ICollection<SocialMedia> SocialMediae { get; set; }
}