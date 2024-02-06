using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class RoleRepository
{
    private readonly List<Role> _roles = new List<Role>();

    public void AddRole(Role role)
    {
        _roles.Add(role);
    }

    public IEnumerable<Role> GetAllRoles()
    {
        return _roles;
    }

    public Role GetRoleById(int id)
    {
        return _roles.FirstOrDefault(r => r.Id == id);
    }

    public void UpdateRole(int id, Role updatedRole)
    {
        var role = GetRoleById(id);
        if (role != null)
        {
            role.Name = updatedRole.Name;
        }
    }

    public void DeleteRole(int id)
    {
        var role = GetRoleById(id);
        if (role != null)
        {
            _roles.Remove(role);
        }
    }
}
