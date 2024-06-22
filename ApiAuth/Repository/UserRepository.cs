using ApiAuth.Contracts;
using ApiAuth.Models;

namespace ApiAuth.Repository
{
    public class UserRepository : IUser
    {
        public User Get(string username, string password)
        {
            var users = new List<User>() 
            {
                new() { Id = 1, Username = "batman", Password = "batman", Role = "manager"},
                new() { Id = 2, Username = "robin", Password = "robin", Role = "employee" }
            };
            
            return users.FirstOrDefault(x => 
                            string.Equals(x.Username, username, StringComparison.CurrentCultureIgnoreCase) 
                            && x.Password == password);
        }
    }
}
