using AppIocDemo.Interfaces;
using AppIocDemo.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AppIocDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AppIocController : ControllerBase
    {
        ICustomerFacade _facade;
        public AppIocController(ICustomerFacade facade)
        {
            _facade = facade;
        }

        [HttpGet(Name = "GetCustomers")]
        public IEnumerable<Customer> Get()
        {

            var list = _facade.GetCustomerList();
            return list;
        }
    }
}
