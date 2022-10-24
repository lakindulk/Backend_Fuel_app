using backend.Model.OwnerLoginRegistration;
using backend.Model.OwnerRegistration;

using MongoDB.Driver;

namespace backend.Service.OwnerService
{
    public class OwnerService:IOwnerService
    {
        private readonly IMongoCollection<OwnerRegistration> _OwnerRegistration;

        public OwnerService(IOwnerLoginDBSettings settings, IMongoClient mongoClient)

        {
            var database = mongoClient.GetDatabase(settings.DatabseName);
            _OwnerRegistration = database.GetCollection<OwnerRegistration>(settings.CollectionName);

        }

        public OwnerRegistration Create(OwnerRegistration ownerRegistration)
        {
            _OwnerRegistration.InsertOne(ownerRegistration);
            return ownerRegistration;
        }

        public List <OwnerRegistration> Get()
        {
            return _OwnerRegistration.Find(ownerRegistration => true).ToList();
        }

        public OwnerRegistration Get(string id)
        {
            return _OwnerRegistration.Find(ownerRegistration => ownerRegistration.Id == id).FirstOrDefault();
        }

        public void Remove(string id)
        {
            _OwnerRegistration.DeleteOne(ownerRegistration => ownerRegistration.Id == id);
        }

        public void Update(string id,OwnerRegistration ownerRegistration)
        {
            _OwnerRegistration.ReplaceOne(ftype => ftype.Id == id, ownerRegistration);
        }
    }
}
