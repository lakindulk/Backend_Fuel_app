namespace backend.Model.OwnerRegistration
{
    public interface ILoginDBSettings
    {
        public string CollectionName { get; set; }
        public string ConnectionString { get; set; }

        public string DatabseName { get; set; }
    }
}
