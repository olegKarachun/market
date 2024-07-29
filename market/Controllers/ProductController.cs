using AutoMapper;
using market.Api;
using market.Api.ApiModel;
using market.Api.ApiModel.Request;
using Market.BLL.Models;
using Market.BLL.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace market.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductService productService;
        private readonly IMapper mapper;
        public ProductController(ProductService productService, IMapper mapper)
        {
            this.mapper = mapper;
            this.productService = productService;
        }

        [HttpGet]
        public async Task<ActionResult<List<ProductApiResponse>>> GetAll()
        {
            var products = await productService.GetAll();
            var result = new List<ProductApiResponse>();

            foreach (var product in products)
            {
                result.Add(mapper.Map<ProductApiResponse>(product));
            }
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProductApiResponse>> GetById(int id)
        {
            var product = await productService.GetById(id);
            if (product == null)
            {
                return NotFound();
            }
            var result = mapper.Map<ProductApiResponse>(product);

            return Ok(product);
        }

        [HttpPost]
        public async Task<ActionResult> Add(ProductApiRequest product)
        {
            var mappedProduct = mapper.Map<ProductBusiness>(product);

            await productService.Add(mappedProduct);
            return CreatedAtAction(nameof(GetById), new { id = mappedProduct.Id }, product);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, ProductApiRequest product)
        {
            var mappedProduct = mapper.Map<ProductBusiness>(product);
            mappedProduct.Id = id;

            await productService.Update(mappedProduct);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await productService.Delete(id);
            return NoContent();
        }
    }
}