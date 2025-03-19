using AppIocDemo.Model.Context;
using AppIocDemo.Model.Entities;
using AppIocDemo.Model.Interfaces;

namespace AppIocDemo.DataLayer.AccessComponents
{
    public class CustomerDac(AppIocContext DataContext, IUserConfig config)
        : ICustomerDac
    {
        public List<Customer> GetCustomers()
        {
            var state = config.State;
            return (from c in DataContext.Customers
                    where (c.Country == config.Country || config.Country == null)
                       && (state != null && c.State == state || state == null)
                    select c).ToList();
        }
    }
}