namespace backend.Model
{
    public class FuelQueueUpdateSettings : IFuelQueueUpdate
    {
        public string CollectionName { get; set; } = String.Empty;
        public string CollectionString { get; set; } = String.Empty;
        public string DatabseName { get ; set ; } = String.Empty;
    }
}
