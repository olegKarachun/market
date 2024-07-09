using Microsoft.AspNetCore.Mvc;
using Trening.Business.Services;

namespace Trening.Controllers.Implementations
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : GenericController<TransactionController>
    {
        public TransactionController(IGenericService<TransactionController> genericService) : base(genericService)
        {
        }
    }
}
