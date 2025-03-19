using AppIocDemo.Model.Entities;

namespace AppIocDemo.Model.Interfaces
{
    public interface ICustomerBe
    {
        List<Customer> GetCustomers();
    }
}
