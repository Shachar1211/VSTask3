using Task3.BL;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Task3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VacationsController : ControllerBase
    {
        // GET: api/<VacationsController>
        [HttpGet]
        public IEnumerable<Vacation> Get()
        {
            Vacation vacation = new Vacation();
            return vacation.Read();
        }

        // GET api/<VacationsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        [HttpGet("getByDates/startDate/endDate")]
        public IEnumerable<Vacation> GetByDates(DateTime startdate, DateTime enddate)
        {
            Vacation vacation = new Vacation();
            return vacation.ReadByDates(startdate, enddate);
        }
        // POST api/<VacationsController>
        [HttpPost]
        public IActionResult Post([FromBody] Vacation vacation)
        {
            if (vacation.Insert())
            {
                return Ok(vacation);
            }
            else
            {
                return BadRequest("Vacation cannot be added");
            }
        }

        // PUT api/<VacationsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<VacationsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
