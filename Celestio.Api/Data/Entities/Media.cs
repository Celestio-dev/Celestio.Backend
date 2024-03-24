namespace Celestio.Api.Data.Entities;

public class Media
{
    public int Id { get; set; }
    public string MediaUrl { get; set; }
    public string MediaType { get; set; }
    
    public DateTime Created { get; set; }
}