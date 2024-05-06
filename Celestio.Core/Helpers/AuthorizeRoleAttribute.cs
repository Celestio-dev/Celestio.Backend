using Celestio.Core.Enums;
using Microsoft.AspNetCore.Authorization;

namespace Celestio.Core.Helpers;

public class AuthorizeRoleAttribute:AuthorizeAttribute
{
    public AuthorizeRoleAttribute(params RolesEnum[] roles)
    {
        Roles = string.Join(",", roles);
    }
}
