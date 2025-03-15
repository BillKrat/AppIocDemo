using AppIocDemo.Interfaces;

namespace AppIocDemo.LayerBusiness.Components
{
    public class ScopedUser(ICustomerFacade facade, IConfig config)
    {
        public void SetState(string state)
        {
            config.State = state;
        }
        public string GetCustomerList(string? country = null)
        {
            return facade.GetCustomerList();
        }
    }
}
