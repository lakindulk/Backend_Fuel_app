namespace backend.Model.UserRegistration
{
    public interface ILoginDBSettings
    {
        public string CollectionName { get; set; }
        public string ConnectionString { get; set; }

        public string DatabseName { get; set; }
    }
}
