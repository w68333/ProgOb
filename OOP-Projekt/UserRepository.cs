using System;
using System.Collections.Generic;
using System.Linq;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
}

public class UserRepository
{
    private readonly List<User> _users = new List<User>();

    // Create
    public void AddUser(User user)
    {
        _users.Add(user);
    }

    // Read
    public IEnumerable<User> GetAllUsers()
    {
        return _users;
    }

    public User GetUserById(int id)
    {
        return _users.FirstOrDefault(u => u.Id == id);
    }

    // Update
    public void UpdateUser(int id, User updatedUser)
    {
        var user = GetUserById(id);
        if (user != null)
        {
            user.Name = updatedUser.Name;
        }
    }

    // Delete
    public void DeleteUser(int id)
    {
        var user = GetUserById(id);
        if (user != null)
        {
            _users.Remove(user);
        }
    }
}
