using TastePlace.Shared.Models;

namespace TastePlace.Client.Interfaces
{
    public interface IUserService
    {
        ValueTask<bool> RegisterUser(User user);
        ValueTask UpdateUser(User user);
        ValueTask<User> Login(User user);
    }
}