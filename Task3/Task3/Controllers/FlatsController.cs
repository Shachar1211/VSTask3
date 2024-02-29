using Task3.BL;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Task3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlatsController : ControllerBase
    {
        // GET: api/<FlatsController>
        [HttpGet]
        public IEnumerable<Flat> Get()
        {
            Flat flat = new Flat();
            return flat.Read();
        }

        // GET api/<FlatsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<FlatsController>
        [HttpPost]
        public IActionResult Post([FromBody] Flat flat)
        {
            if (flat.Insert())
            {
                return Ok(flat);    
            }
            else
            {
                return BadRequest("Flat ID is not uniq");
            }
                 
        }
        [HttpGet("search")]
        public IEnumerable<Flat> GetFlatsByPriceAndCity(double price, string city)
        {
            Flat flat = new Flat();
            return flat.ReadByPriceAndCity(price, city);
        }

        // PUT api/<FlatsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<FlatsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
