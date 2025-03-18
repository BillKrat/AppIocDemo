using AppIocDemo.Models.Entities;

namespace AppIocDemo.Interfaces
{
    public interface ICustomerFacade
    {
        List<Customer> GetCustomerList();
    }
}
