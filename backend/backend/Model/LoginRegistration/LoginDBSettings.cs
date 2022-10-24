namespace backend.Model.UserRegistration
{
    public class LoginDBSettings : ILoginDBSettings
    {
        public string CollectionName { get; set; } = string.Empty;
        public string ConnectionString { get; set; } = string.Empty;

        public string DatabseName { get; set; } = string.Empty;


    }
}
