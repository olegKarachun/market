using Microsoft.AspNetCore.Mvc;
using Trening.Business.Services;

namespace Trening.Controllers.Implementations
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : GenericController<Customer>
    {
        public CustomerController(IGenericService<Customer> genericService) : base(genericService)
        {
        }
    }
}
