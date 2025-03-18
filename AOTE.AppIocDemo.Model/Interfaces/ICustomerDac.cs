using AppIocDemo.Models.Entities;

namespace AppIocDemo.Interfaces
{
    public interface ICustomerDac
    {
        List<Customer> GetCustomers();
    }
}
