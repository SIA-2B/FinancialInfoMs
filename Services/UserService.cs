using Financial_ms.Models;
using MongoDB.Driver;

namespace Financial_ms.Services
{
    public class UserService : IUserService
    {
        private readonly IMongoCollection<User> _user;  
        public UserService( IUserDatabaseSettings settings, IMongoClient mongoClient )
        {
            var userdatabase = mongoClient.GetDatabase(settings.DatabaseName);
            _user = userdatabase.GetCollection<User>(settings.CollectionName);
        }

       public User Create(User user)
       {
            _user.InsertOne(user);
            return user;
       }

       public List<User> Get()
       {
            return _user.Find(user => true).ToList();
       }

       public User Get(string id)
       {
            return _user.Find(user => user.Id == id).FirstOrDefault();
       }

       public List<User> GetName(string name)
       {
            return _user.Find(user => user.Name == name).ToList();
       }
       
       public void Remove(string? id)
       {
            _user.DeleteOne(user => user.Id == id);
       }

       public void Update(string id, User user)
       {
            _user.ReplaceOne(user => user.Id == id, user);
       }

    }
}