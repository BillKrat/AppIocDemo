using AppIocDemo.Interfaces;
using AppIocDemo.Models;

namespace AppIocDemo.LayerBusiness.Components
{
    public class ScopedUser(ICustomerFacade facade, IConfig config)
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
