namespace Celestio.Api.Data.Entities;

public class UserMediaCategory
{
    public int Id { get; set; }
    public int UserMediaId { get; set; }
    public int CategoryId { get; set; }
    
    public virtual UserMedia UserMedia { get; set; }
    public virtual Category Category { get; set; }

}