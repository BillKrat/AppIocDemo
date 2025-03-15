using AppIocDemo.Interfaces;
using AppIocDemo.Models;

namespace AppIocDemo.LayerBusiness.Entities
{
    public class CustomerBe(ICustomerDac dal) : ICustomerBe
    {
        public List<Customer> GetCustomers()
        {
            return dal.GetCustomers();
        }
    }
}
