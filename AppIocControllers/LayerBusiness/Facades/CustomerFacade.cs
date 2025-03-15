using AppIocControllers.Interfaces;

namespace AppIocControllers.LayerBusiness.Facades
{
    public class CustomerFacade(ICustomerBe be) : ICustomerFacade
    {
        public string GetCustomerList()
        {
            var custData = be.GetCustomers();
            var value = ($"== Total records: {custData.Count()}\r\n");
            foreach (var cust in custData)
            {
                value += $"{cust.FirstName} {cust.LastName}, " +
                         $"{cust.Address}, {cust.State}\r\n";
            }
            return value;
        }
    }
}
