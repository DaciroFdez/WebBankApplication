using Microsoft.AspNetCore.Mvc;
using WebApiBank.DataBase;
using WebApiBank.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiBank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SiteController : ControllerBase
    {
        private readonly BankApiDB _dbContex;

        public SiteController(BankApiDB dbContext)
        {
            _dbContex = dbContext;
        }


        // GET: api/<SitesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<SitesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SitesController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Site site)
        {
            try
            {
                _dbContex.Sites.Add(site);
                await _dbContex.SaveChangesAsync();
                return Ok("Creado");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<SitesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SitesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
