using AOTE.Framework.CrossCutting.Interfaces;
using AppIocDemo.DataSource.EF;
using AppIocDemo.Interfaces;
using AppIocDemo.Models;

namespace AppIocDemo.LayerData.AccessComponents
{
    public class CustomerDac(AppIocContext DataContext, IConfig config)
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