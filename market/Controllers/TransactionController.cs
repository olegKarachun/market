using AutoMapper;
using market.Api;
using market.Api.ApiModel;
using market.Api.ApiModel.Request;
using market.Api.ApiModel.Response;
using Market.BLL.Models;
using Market.BLL.Service;
using Market.DAL.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Market.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TransactionController : ControllerBase
    {
        private readonly TransactionService transactionService;
        private readonly IMapper mapper;

        public TransactionController(TransactionService transactionService, IMapper mapper)
        {
            this.transactionService = transactionService;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<TransactionApiResponse>>> GetAll()
        {
            var transactions = await transactionService.GetAll();
            var result = new List<TransactionApiResponse>();

            foreach (var transaction in transactions)
            {
                result.Add(mapper.Map<TransactionApiResponse>(transaction));
            }
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TransactionApiResponse>> GetById(int id)
        {
            var transaction = await transactionService.GetById(id);
            if (transaction == null)
            {
                return NotFound();
            }
            var result = mapper.Map<TransactionApiResponse>(transaction);

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult> Add(TransactionApiRequest transaction)
        {
            var mappedTransaction = mapper.Map<TransactionBusiness>(transaction);

            await transactionService.Add(mappedTransaction);
            return CreatedAtAction(nameof(GetById), new { id = mappedTransaction.Id }, transaction);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, TransactionApiRequest transaction)
        {
            var mappedTransaction = mapper.Map<TransactionBusiness>(transaction);
            mappedTransaction.Id= id;

            await transactionService.Update(mappedTransaction);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await transactionService.Delete(id);
            return NoContent();
        }
    }
}
