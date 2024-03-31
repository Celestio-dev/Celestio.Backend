namespace Celestio.Core.Models.Media;

public class MediaDto
{
    public int Id { get; set; }
    public string MediaUrl { get; set; }
    public string MediaType { get; set; }
    
    public DateTime Created { get; set; }
}