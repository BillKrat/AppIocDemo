using AppIocDemo.Models.Entities;

namespace AppIocDemo.Interfaces
{
    public interface ICustomerBe
    {
        List<Customer> GetCustomers();
    }
}
