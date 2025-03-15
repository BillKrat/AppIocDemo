using AppIocControllers.Interfaces;
using AppIocControllers.Models;

namespace AppIocControllers.LayerBusiness.Entities
{
    public class CustomerBe(ICustomerDac dal) : ICustomerBe
    {
        public List<Customer> GetCustomers()
        {
            return dal.GetCustomers();
        }
    }
}
