using AppIocDemo.Models;

namespace AppIocDemo.Interfaces
{
    public interface ICustomerFacade
    {
        List<Customer> GetCustomerList();
    }
}
