using AppIocDemo.Model.Entities;

namespace AppIocDemo.Model.Interfaces
{
    public interface ICustomerFacade
    {
        List<Customer> GetCustomerList();
    }
}
