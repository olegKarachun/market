using Microsoft.AspNetCore.Mvc;
using Trening.Business.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Trening.Controllers.Implementations
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
