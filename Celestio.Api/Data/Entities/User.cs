using Celestio.Core.Enums;

namespace Celestio.Api.Data.Entities;

public class User
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string? UserDescription { get; set; }
    public string Email { get; set; }
    //public string Username { get; set; }
    public int RoleId { get; set; }
    public int CompanyId { get; set; }
    public int? ProfilePicMediaId { get; set; }
    public byte[] PasswordHash { get; set; }
    public byte[] PasswordSalt { get; set; }
    public DateTime? Created { get; set; }

    
    public virtual Role Role { get; set; }
    public virtual Company Company { get; set; }
    public virtual Media ProfilePicMedia { get; set; }
    public virtual ICollection<SocialMedia> SocialMediae { get; set; }
}