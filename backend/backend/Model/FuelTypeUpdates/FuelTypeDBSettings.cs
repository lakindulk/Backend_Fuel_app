namespace backend.Model.FuelTypeUpdates
{
    public class FuelTypeDBSettings : IFuelTypeDBSettings
    {
        public string CollectionName { get; set; } = string.Empty;
        public string ConnectionString { get; set; } = string.Empty;

        public string DatabseName { get; set; } = string.Empty;


    }
}
