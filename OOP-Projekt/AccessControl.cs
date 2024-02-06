using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static bool CheckAccess(User user, Resource resource, Permission requiredPermission)
{
    foreach (var role in user.Roles)
    {
        if (role.Permissions.TryGetValue(resource.Id, out var permissions) && permissions.Contains(requiredPermission))
        {
            return true;
        }
    }
    return false;
}
