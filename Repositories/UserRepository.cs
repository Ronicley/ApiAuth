using ApiAuth.Models;

namespace ApiAuth.Repositories;

public class UserRepository
{
    public static User Get(string userName, string password)
    {
        var users = new List<User>
        {
            new() { Id = 1, UserName = "batman", Password = "batman", Role = "manager" },
            new() { Id = 1, UserName = "robin", Password = "robin", Role = "employee" }
        };

        return users.FirstOrDefault(user => user.UserName.ToLower() == userName && user.Password == password);
    }
}