using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using Celestio.Core.Enums;

namespace Celestio.Core.Helpers;

public class UserHelper
{
    public static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
    {
        using var hmac = new HMACSHA512();
        passwordSalt = hmac.Key;
        passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
    }

    public static bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
    {
        using var hmac = new HMACSHA512(passwordSalt);
        var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
        return computedHash.SequenceEqual(passwordHash);
    }
    
    public static AuthenticatedUser? GetAuthUserFromClaims(ClaimsPrincipal User)
    {
        // returns null if the user is unauthorized
        AuthenticatedUser authUser = new AuthenticatedUser();

        string authUserIdString = User.FindFirstValue(ClaimTypes.NameIdentifier);
        //string authUserEmail = User.FindFirstValue(ClaimTypes.Email);
        string authUserCompanyIdString = User.FindFirstValue(CelestioClaimTypes.CompanyId);
        string authUserRoleString = User.FindFirstValue(ClaimTypes.Role);
        //string authUserTempUserId = User.FindFirstValue(CPMSClaimTypes.TempUserId);

        if (string.IsNullOrEmpty(authUserRoleString) || !Int32.TryParse(authUserIdString, out int authUserId) ||
            !Int32.TryParse(authUserCompanyIdString, out int authUserCompanyId))
            return null; // if null is returned the api endpoint should return unauthorized()

        authUser.UserId = authUserId;
        authUser.CompanyId = authUserCompanyId;
        authUser.Role = (RolesEnum) Enum.Parse(typeof(RolesEnum), authUserRoleString);
            
        //Guid.TryParse(authUserTempUserId, out Guid tempUserId);
        //authUser.TempUserId = tempUserId;
            
        return authUser;
    }
}