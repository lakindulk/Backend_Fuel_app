using backend.Model;

namespace backend.Service
{
    public interface IFuelQueueUpdateService
    {
        List<FuelQueueUpdate> Get();
        FuelQueueUpdate Get(string id);
        FuelQueueUpdate Create(FuelQueueUpdate fuelQueue);
        void Update(string id,FuelQueueUpdate fuelQueue);
        void Remove(string id);

    }
}
