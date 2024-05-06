using Celestio.Core.Enums;
using Celestio.Core.Models.Brand;
using Celestio.Core.Models.Company;
using Celestio.Core.Models.Media;

namespace Celestio.Core.Models.Brief;

public class BriefDto
{
    public int Id { get; set; }
    public string BriefTitle { get; set; }
    public string BriefDescription { get; set; }
    public double Budget { get; set; }
    public BriefStatus Status { get; set; }

    public DateTime Created { get; set; }
    
    public virtual BrandMiniDto Brand { get; set; }
    public virtual CompanyMiniDto Company { get; set; }
    public virtual ICollection<MediaDto> Mediae { get; set; }
}