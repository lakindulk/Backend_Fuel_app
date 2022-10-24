using backend.Model;
using MongoDB.Driver;

namespace backend.Service
{
    public class FuelQueueUpdateService : IFuelQueueUpdateService
    {
        private readonly IMongoCollection<FuelQueueUpdate> _queue;

        public FuelQueueUpdateService (IFuelQueueUpdate settings, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(settings.DatabseName);
            _queue = database.GetCollection<FuelQueueUpdate>(settings.CollectionName);
        }
        public FuelQueueUpdate Create(FuelQueueUpdate fuelQueue)
        {
            _queue.InsertOne(fuelQueue);
            return fuelQueue;
        }

        public List<FuelQueueUpdate> Get()
        {
            return _queue.Find(queue => true).ToList();
        }

        public FuelQueueUpdate Get(string id)
        {
            return _queue.Find(queue => queue.Id == id).FirstOrDefault();
        }

        public void Remove(string id)
        {
            _queue.DeleteOne(queue => queue.Id == id);
        }

        public void Update(string id, FuelQueueUpdate fuelQueue)
        {
            _queue.ReplaceOne(queue => queue.Id == id, fuelQueue); ;
        }
    }
}
