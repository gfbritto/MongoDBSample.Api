using Microsoft.AspNetCore.Mvc;
using MongoDBSample.Models.Documents;
using MongoDBSample.Repository.Generic;

namespace MongoDBSample.Api.Controllers
{
    [Route("[controller]")]
    public class CustomersController : Controller
    {
        private readonly IGenericRepository<Customer> _repository;

        public CustomersController(IGenericRepository<Customer> repository)
        {
            _repository = repository;
        }

        [HttpGet("get-all")]
        public async Task<IActionResult> GetCustomers()
        {
            var results = await _repository.FindAll();
            return Ok(results);
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateCustomer([FromBody] Customer customer)
        {
            await _repository.InsertOneAsync(customer);
            return Created("find-by-id", customer);
        }
    }
}
