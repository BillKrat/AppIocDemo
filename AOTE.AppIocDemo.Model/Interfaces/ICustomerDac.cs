using AppIocDemo.Model.Entities;

namespace AppIocDemo.Model.Interfaces
{
    public interface ICustomerDac
    {
        List<Customer> GetCustomers();
    }
}
