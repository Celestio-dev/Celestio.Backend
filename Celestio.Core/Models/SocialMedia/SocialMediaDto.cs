using Celestio.Core.Enums;

namespace Celestio.Core.Models.SocialMedia;

public class SocialMediaDto
{
    public int Id { get; set; }
    //public int DocId { get; set; }
    //public string TableName { get; set; }
    public SocialMediaEnum SocialMediaName { get; set; }
    public string SocialMediaUsername { get; set; }
    public string SocialMediaUrl { get; set; }
    //public DateTime Created { get; set; }
}