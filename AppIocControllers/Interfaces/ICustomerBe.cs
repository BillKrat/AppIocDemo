using AppIocControllers.Models;

namespace AppIocControllers.Interfaces
{
    public interface ICustomerBe
    {
        List<Customer> GetCustomers();
    }
}
