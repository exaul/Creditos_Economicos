using Creditos_Ecomicos_2024.Data;
using Creditos_Ecomicos_2024.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Creditos_Ecomicos_2024.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly CreditosDbContext creditosDb;

        public ClientesController(CreditosDbContext creditosDb)
        {
            this.creditosDb = creditosDb;
        }
        // GET: api/<ClientesController>
        [HttpGet]
        public IEnumerable<Cliente> Get()
        {
            return creditosDb.Clientes.ToList();
        }

        // GET api/<ClientesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ClientesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ClientesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ClientesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
