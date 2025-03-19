using AppIocDemo.Model.Entities;
using AppIocDemo.Model.Interfaces;

namespace AppIocDemo.BusinessLayer.Components
{
    public class CustomerBe(ICustomerDac dal) : ICustomerBe
    {
        public List<Customer> GetCustomers()
        {
            return dal.GetCustomers();
        }
    }
}
