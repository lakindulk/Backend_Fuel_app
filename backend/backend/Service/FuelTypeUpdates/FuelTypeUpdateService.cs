using backend.Model.FuelTypeUpdates;

using MongoDB.Driver;

namespace backend.Service.FuelTypeUpdates
{
    public class FuelTypeUpdateService:IFuelTypeUpdateService
    {
        private readonly IMongoCollection<FuelTypeUpdate> _fuelTypeUpdate;

        public FuelTypeUpdateService(IFuelTypeDBSettings settings, IMongoClient mongoClient)

        {
            var database = mongoClient.GetDatabase(settings.DatabseName);
            _fuelTypeUpdate = database.GetCollection<FuelTypeUpdate>(settings.CollectionName);

        }

        public FuelTypeUpdate Create(FuelTypeUpdate fuelTypeUpdate)
        {
            _fuelTypeUpdate.InsertOne(fuelTypeUpdate);
            return fuelTypeUpdate;
        }

        public List <FuelTypeUpdate> Get()
        {
            return _fuelTypeUpdate.Find(fuelTypeUpdate => true).ToList();
        }

        public FuelTypeUpdate Get(string id)
        {
            return _fuelTypeUpdate.Find(fuelTypeUpdate => fuelTypeUpdate.Id == id).FirstOrDefault();
        }

        public FuelTypeUpdate GetStations(string id)
        {
            return _fuelTypeUpdate.Find(fuelTypeUpdate => fuelTypeUpdate.StationID == id).FirstOrDefault();
        }

        public void Remove(string id)
        {
            _fuelTypeUpdate.DeleteOne(FuelTypeUpdate => FuelTypeUpdate.Id == id);
        }

        public void Update(string id,FuelTypeUpdate fuelTypeUpdate)
        {
            _fuelTypeUpdate.ReplaceOne(ftype => ftype.Id == id, fuelTypeUpdate);
        }
    }
}
