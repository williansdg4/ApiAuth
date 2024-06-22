using ApiAuth.Models;

namespace ApiAuth.Contracts
{
    public interface IUser
    {
        User Get(string username, string password);
    }
}
