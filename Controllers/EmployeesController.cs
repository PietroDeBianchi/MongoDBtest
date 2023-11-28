using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using mongoDB.Models;
using MongoDB.Driver;
using MongoDBtest.Models;

namespace MongoDB.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeesController : ControllerBase
    {
        private IMongoCollection<Employee> _employees;
        public EmployeesController(IOptions<EmployeesDbConfig> options)
        {
            var mongoClient = new MongoClient(options.Value.ConnectionString);
            var mongoDb = mongoClient.GetDatabase(options.Value.DatabaseName);
            _employees = mongoDb.GetCollection<Employee>(options.Value.EmployeesCollectionName);
        }

        [HttpGet]
        public async Task<List<Employee>> Get()
        {
            return await _employees.Find(e => true).ToListAsync();
        }
    }
}
