using AppIocControllers.Models;

namespace AppIocControllers.Interfaces
{
    public interface ICustomerDac
    {
        List<Customer> GetCustomers();
    }
}
