using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Trening.Controllers.GenericControlle;
using Trening.Services.Interfaces;

namespace Trening.Controllers
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
