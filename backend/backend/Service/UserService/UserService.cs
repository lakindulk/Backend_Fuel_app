using backend.Model.LoginRegistration;
using backend.Model.UserRegistration;

using MongoDB.Driver;

namespace backend.Service.UserService
{
    public class UserService:IUserService
    {
        private readonly IMongoCollection<UserRegistration> _UserRegistration;

        public UserService(ILoginDBSettings settings, IMongoClient mongoClient)

        {
            var database = mongoClient.GetDatabase(settings.DatabseName);
            _UserRegistration = database.GetCollection<UserRegistration>(settings.CollectionName);

        }

        public UserRegistration Create(UserRegistration userRegistration)
        {
            _UserRegistration.InsertOne(userRegistration);
            return userRegistration;
        }

        public List <UserRegistration> Get()
        {
            return _UserRegistration.Find(userRegistration => true).ToList();
        }

        public UserRegistration Get(string id)
        {
            return _UserRegistration.Find(userRegistration => userRegistration.Id == id).FirstOrDefault();
        }

        public void Remove(string id)
        {
            _UserRegistration.DeleteOne(userRegistration => userRegistration.Id == id);
        }

        public void Update(string id,UserRegistration userRegistration)
        {
            _UserRegistration.ReplaceOne(ftype => ftype.Id == id, userRegistration);
        }
    }
}
