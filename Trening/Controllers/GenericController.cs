using Microsoft.AspNetCore.Mvc;
using Trening.BLL.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Trening.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenericController<T> : ControllerBase where T : IApiModel //dont change
    {
        private readonly IGenericService<T> genericService;
        public GenericController(IGenericService<T> genericService)
        {
            this.genericService = genericService;
        }

        // GET: api/<GenericController>
        [HttpGet]
        public List<T> GetAll()
        {
            return genericService.GetAll();
        }

        // GET api/<GenericController>/5
        [HttpGet("{id}")]
        public T Get(int id)
        {
            return genericService.GetById(id);
        }

        // POST api/<GenericController>
        [HttpPost]
        public void Post([FromBody] T entity)
        {
            genericService.Update(entity);
        }

        // PUT api/<GenericController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<GenericController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
