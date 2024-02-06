using System;
using System.Collections.Generic;

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

public class UserRepository
{
    private List<User> users = new List<User>();

    public void AddUser(User user)
    {
        users.Add(user);
    }

    public User GetUserById(int userId)
    {
        return users.Find(user => user.UserId == userId);
    }

    public void UpdateUser(User updatedUser)
    {
        User existingUser = users.Find(user => user.UserId == updatedUser.UserId);
        if (existingUser != null)
        {
            existingUser.UserName = updatedUser.UserName;
        }
        else
        {
            throw new ArgumentException("ID niema");
        }
    }

    public void DeleteUser(int userId)
    {
        User userToRemove = users.Find(user => user.UserId == userId);
        if (userToRemove != null)
        {
            users.Remove(userToRemove);
        }
        else
        {
            throw new ArgumentException("ID niema");
        }
    }
}
