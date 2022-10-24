namespace backend.Model.FuelTypeUpdates
{
    public interface IFuelTypeDBSettings
    {
        public string CollectionName { get; set; }
        public string ConnectionString { get; set; }

        public string DatabseName { get; set; }
    }
}
