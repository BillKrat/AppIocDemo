using AppIocDemo.DataSource.EF;
using AppIocDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace AppIocDemo.LayerPresentation.UiProcessComponents.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AppIocController : ControllerBase
    {
        private AppIocContext _context;
        private readonly ILogger<AppIocController> _logger;

        public AppIocController(ILogger<AppIocController> logger,
            AppIocContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet(Name = "GetCustomers")]
        public IEnumerable<Customer> Get()
        {

            var list = _context.Customers.ToList();
            return list;
        }
    }
}
