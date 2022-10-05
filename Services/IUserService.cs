using Financial_ms.Models;

namespace Financial_ms.Services
{
    public interface IUserService
    {
	   List<User> Get();
       User Get(string id);
       List<User> GetName(string name);
       User Create(User user);
       void Update(string id, User user);
       void Remove(string? id);
    }
}