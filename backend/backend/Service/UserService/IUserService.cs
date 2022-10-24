using backend.Model.UserRegistration;
namespace backend.Service.UserService
{
    public interface IUserService
    {

        List<UserRegistration> Get();
        UserRegistration Get(string Id);
        UserRegistration Create(
            UserRegistration userRegistration);
        void Update(string Id, UserRegistration userRegistration);
        void Remove(string Id);

    }
}
