using AutoMapper;
using market.Api;
using market.Api.ApiModel;
using market.Api.ApiModel.Request;
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
    public class CustomerController : ControllerBase
    {
        private readonly CustomerService customerService;
        private readonly IMapper mapper;
        public CustomerController(CustomerService customerService, IMapper mapper)
        {
            this.customerService = customerService;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<CustomerApiResponse>>> GetAll()
        {
            var customers = await customerService.GetAll();
            var result = new List<CustomerApiResponse>();

            foreach(var customer in customers)
            {
                result.Add(mapper.Map<CustomerApiResponse>(customer));
            }
            return Ok(customers);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CustomerApiResponse>> GetById(int id)
        {
            var customer = await customerService.GetById(id);
            if (customer == null)
            {
                return NotFound();
            }

            var result = mapper.Map<CustomerApiResponse>(customer);

            return Ok(customer);
        }

        [HttpPost]
        public async Task<ActionResult> Add(CustomerApiRequest customer)
        {
            if (customer == null)
            {
                return NotFound();
            }
            var mappedCustomer = mapper.Map<CustomerBusiness>(customer);

            await customerService.Add(mappedCustomer);
            return CreatedAtAction(nameof(GetById), new { id = customer }, customer);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, CustomerApiRequest customer)
        {
            var mappedCustomer = mapper.Map<CustomerBusiness>(customer);
            mappedCustomer.Id = id;

            await customerService.Update(mappedCustomer);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await customerService.Delete(id);
            return NoContent();
        }
    }
}
