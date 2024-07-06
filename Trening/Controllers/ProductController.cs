using Microsoft.AspNetCore.Mvc;
using Trening.Controllers.GenericControlle;
using Trening.Models;
using Trening.Services.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Trening.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : GenericController<Product>
    {
        public ProductController(IGenericService<Product> genericService) : base(genericService)
        {
        }
    }
}
