namespace Celestio.Api.Data.Entities;

public class Submission
{
    public int Id { get; set; }
    public string SubmissionTitle { get; set; }
    public string SubmissionDescription { get; set; }
    public int UserId { get; set; }
    public int BriefId { get; set; }
    public int MediaId { get; set; }
    public int WatermarkMediaId { get; set; }
    
    public DateTime Created { get; set; }
}