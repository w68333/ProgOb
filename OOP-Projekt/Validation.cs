using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class UserService
{
    private readonly List<User> _users = new List<User>();

    public void CreateUser(User user)
    {
        try
        {
            ValidateUser(user);
            _users.Add(user);
        }
        catch (Exception ex)
        {           
            LogException(ex);          
            throw new ApplicationException("Bląd");
        }
    }

    private void ValidateUser(User user)
    {
        if (_users.Any(u => u.Id == user.Id))
        {
            throw new ArgumentException(" ID już istnieje.");
        }
        if (!IsValidUserName(user.Name))
        {
            throw new ArgumentException("Bląd imia");
        }
    }

    private bool IsValidUserName(string userName)
    {
       
        return !string.IsNullOrEmpty(userName) && userName.Length >= 3 && userName.Length <= 50;
    }


    private void LogException(Exception ex)
    {     
        Console.WriteLine(ex.Message);
    }
}
