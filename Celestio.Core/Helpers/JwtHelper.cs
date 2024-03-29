using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Celestio.Core.Enums;
using Celestio.Core.Models.User;
using Microsoft.IdentityModel.Tokens;

namespace Celestio.Core.Helpers;

public class JwtHelper
{
    public static string CreateToken(UserDto user, string roleName, string jwtKey)
    {
        //var roleName = Enum.GetName(typeof(RolesEnum), user.RoleId);
        List<Claim> claims = new()
        {
            //new Claim(ClaimTypes.Name, user.Username),
            new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
            new Claim(ClaimTypes.Email, user.Email),
            new Claim(CelestioClaimTypes.CompanyId, user.CompanyId.ToString()),
            new Claim(ClaimTypes.Role, roleName)
        };

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtKey));
        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);
        var token = new JwtSecurityToken(
            claims: claims,
            expires: DateTime.Now.AddDays(1),
            signingCredentials: creds
        );
        var jwt = new JwtSecurityTokenHandler().WriteToken(token);

        return jwt;
    }
}