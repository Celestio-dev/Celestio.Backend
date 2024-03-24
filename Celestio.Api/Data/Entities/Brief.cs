using Celestio.Core.Enums;

namespace Celestio.Api.Data.Entities;

public class Brief
{
    public int Id { get; set; }
    public string BriefTitle { get; set; }
    public string BriefDescription { get; set; }
    public double Budget { get; set; }
    public BriefStatus Status { get; set; }
    public int BrandId { get; set; }

    public DateTime Created { get; set; }
    
    public virtual Brand Brand { get; set; }
    public virtual ICollection<Media> Mediae { get; set; }
}