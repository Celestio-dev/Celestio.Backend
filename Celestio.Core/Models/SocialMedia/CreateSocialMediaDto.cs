using Celestio.Core.Enums;

namespace Celestio.Core.Models.SocialMedia;

public class CreateSocialMediaDto
{
    public SocialMediaEnum SocialMediaName { get; set; }
    public string SocialMediaUsername { get; set; }
    public string SocialMediaUrl { get; set; }
}