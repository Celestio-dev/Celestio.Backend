namespace Celestio.Core.Helpers;

public class AuthenticatedUser
{
    public int UserId { get; set; }
    public int CompanyId { get; set; }
    public string Role { get; set; }
}