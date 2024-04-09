namespace Celestio.Api.Data.Entities;

public class UserMedia
{
    public int Id { get; set; }
    public int MediaId { get; set; }
    public int UserId { get; set; }
    
    public virtual User User { get; set; }
    public virtual Media Media { get; set; }
    public virtual ICollection<UserMediaCategory> UserMediaCategories { get; set; }

}