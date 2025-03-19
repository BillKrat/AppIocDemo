using AppIocDemo.Model.Entities;
using AppIocDemo.Model.Interfaces;

namespace AppIocDemo.LayerBusiness.Components
{
    public class ScopedUser(ICustomerFacade facade, IUserConfig config)
    {
        public void SetState(string state)
        {
            config.State = state;
        }
        public List<Customer> GetCustomerList(string? country = null)
        {
            return facade.GetCustomerList();
        }
    }
}
