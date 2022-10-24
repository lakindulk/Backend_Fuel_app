namespace backend.Model.OwnerRegistration
{
    public interface IOwnerLoginDBSettings
    {
        public string CollectionName { get; set; }
        public string ConnectionString { get; set; }

        public string DatabseName { get; set; }
    }
}
