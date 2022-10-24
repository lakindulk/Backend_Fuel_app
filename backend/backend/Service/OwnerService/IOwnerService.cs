using backend.Model.OwnerLoginRegistration;
using backend.Model.UserRegistration;
namespace backend.Service.OwnerService
{
    public interface IOwnerService
    {

        List<OwnerRegistration> Get();
        OwnerRegistration Get(string Id);
        OwnerRegistration Create(
            OwnerRegistration ownerRegistration);
        void Update(string Id, OwnerRegistration ownerRegistration);
        void Remove(string Id);

    }
}
