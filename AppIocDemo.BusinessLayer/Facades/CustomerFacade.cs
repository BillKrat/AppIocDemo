using AppIocDemo.Model.Entities;
using AppIocDemo.Model.Interfaces;

namespace AppIocDemo.BusinessLayer.Facades
{
    public class CustomerFacade(ICustomerBe be) : ICustomerFacade
    {
        public List<Customer> GetCustomerList()
        {
            var custData = be.GetCustomers();
            return custData;
        }
    }
}
