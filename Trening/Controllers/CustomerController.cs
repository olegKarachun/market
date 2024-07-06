using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;
using Trening.Controllers.GenericControlle;
using Trening.DB;
using Trening.Models;
using Trening.Services.Interfaces;

namespace Trening.Controllers
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
