namespace backend.Model.OwnerRegistration
{
    public class OwnerLoginDBSettings : IOwnerLoginDBSettings
    {
        public string CollectionName { get; set; } = string.Empty;
        public string ConnectionString { get; set; } = string.Empty;

        public string DatabseName { get; set; } = string.Empty;


    }
}
