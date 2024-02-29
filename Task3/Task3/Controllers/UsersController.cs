using Microsoft.AspNetCore.Mvc;
using Task3.BL;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Task3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        // GET: api/<UsersController>
        [HttpGet]
        public IEnumerable<User> Get()
        {
            User user = new User();
            return user.Read();
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UsersController>
        [HttpPost]
        public IActionResult Post([FromBody] User user)
        {
            if (user.Insert())
            {
                return Ok(user);
            }
            else
            {
                return BadRequest("User email is not uniq");
            }
        }

        [HttpPost]
        [Route("LogIn")]
        public User LogIn([FromBody] User user)
        {
            return user.LogIn();

            //if (user.LogIn())
            //{
            //    return Ok(user.LogIn());
            //}
            //else
            //{
            //    return BadRequest("User email is not uniq");
            //}
        }

        // PUT api/<UsersController>/5
        [HttpPut("{email}")]
        public IActionResult Put( [FromBody] User user)
        {
            if (user.Update()==1)
            {
                return Ok(user);
            }
            else
            {
                return BadRequest("User is not updated");
            }

        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
