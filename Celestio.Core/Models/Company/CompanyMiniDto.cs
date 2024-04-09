using Celestio.Core.Models.Media;

namespace Celestio.Core.Models.Company;

public class CompanyMiniDto
{
    public int Id { get; set; }
    public string CompanyName { get; set; }
    public virtual MediaDto ProfilePicMedia { get; set; }
}