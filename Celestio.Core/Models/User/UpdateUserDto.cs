using Celestio.Core.Models.SocialMedia;

namespace Celestio.Core.Models.User;

public class UpdateUserDto
{
    public string? UserDescription { get; set; }
    public virtual ICollection<SocialMediaDto> SocialMediae { get; set; }
    
    // TODO dodaj kategorije
    // TODO dodaj polje za profile pic
}