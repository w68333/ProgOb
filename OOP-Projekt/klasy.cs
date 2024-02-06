using System.Security;

public class User
{
    public int UserId { get; set; }
    public string UserName { get; set; }

    public User(int userId, string userName)
    {
        UserId = userId;
        UserName = userName;
    }
}

public class Role
{
    public int Id { get; set; }
    public string Name { get; set; }
   
    public Dictionary<int, List<Permission>> Permissions { get; set; } = new Dictionary<int, List<Permission>>();
}

public class Resource
{
    public int ResourceId { get; set; }
    public string ResourceName { get; set; }

    public Resource(int resourceId, string resourceName)
    {
        ResourceId = resourceId;
        ResourceName = resourceName;
    }
}

public enum Permission
{
    Read,
    Write,
    Delete
}