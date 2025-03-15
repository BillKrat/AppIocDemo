using AppIocDemo.Models;

namespace AppIocDemo.Interfaces
{
    public interface ICustomerDac
    {
        List<Customer> GetCustomers();
    }
}
