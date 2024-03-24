namespace Celestio.Api.Data.Entities;

public class Brand
{
    public int Id { get; set; }
    public string BrandName { get; set; }
    public string BrandDescription { get; set; }
    public int ProfilePicMediaId { get; set; }
    
    public DateTime Created { get; set; }
    
    public virtual ICollection<Brief> Briefs { get; set; }
    public virtual Media ProfilePicMedia { get; set; }
    public virtual ICollection<SocialMedia> SocialMediae { get; set; }

}