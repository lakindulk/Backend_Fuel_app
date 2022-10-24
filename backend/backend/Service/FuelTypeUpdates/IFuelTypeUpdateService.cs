using backend.Model.FuelTypeUpdates;
namespace backend.Service.FuelTypeUpdates
{
    public interface IFuelTypeUpdateService
    {
        List<FuelTypeUpdate> Get();
        FuelTypeUpdate Get(string Id);
        FuelTypeUpdate Create(
            FuelTypeUpdate fuelTypeUpdate);
        void Update(string Id, FuelTypeUpdate fuelTypeUpdate);
        void Remove(string Id);

    }
}
