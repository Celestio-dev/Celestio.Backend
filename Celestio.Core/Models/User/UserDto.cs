namespace Celestio.Core.Models.User;

public class UserDto
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
    public DateTime? Created { get; set; }

    
    // public virtual RoleDto Role { get; set; }
    // public virtual CompanyDto Company { get; set; }
    // public virtual MediaDto ProfilePicMedia { get; set; }
    // public virtual ICollection<SocialMediaDto> SocialMediae { get; set; }

}