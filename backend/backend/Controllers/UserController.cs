using backend.Model.LoginRegistration;
using backend.Service.UserService;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService userTypeService;

        public UserController(IUserService userService)
        {
            this.userTypeService = userService;
        }

        // GET: api/<userTypeService>
        [HttpGet]
        public ActionResult<List<UserRegistration>> Get()
        {
            return userTypeService.Get();
        }

        // GET api/<userTypeService>/5
        [HttpGet("{id}")]
        public ActionResult<UserRegistration> Get(string id)
        {


            var userTypeUpdate = userTypeService.Get(id);
            if (userTypeUpdate == null)
            {
                return NotFound($"supplier with id = {id} not found");
            }
            return userTypeUpdate;
        }

        // POST api/<userTypeService>
        [HttpPost]
        public ActionResult<UserRegistration> Post([FromBody] UserRegistration usertypeUpdate)
        {
            userTypeService.Create(usertypeUpdate);
            return CreatedAtAction(nameof(Get), new { id = usertypeUpdate.Id }, usertypeUpdate);
        }

        // PUT api/<userTypeService>/5
        [HttpPut("{id}")]
        public ActionResult Put(string id, [FromBody] UserRegistration usertypeUpdate)
        {
            var existingusertype = userTypeService.Get(id);
            if (existingusertype == null)
            {
                return NotFound($"Supplier with id = {id} not found");
            }
            userTypeService.Update(id, usertypeUpdate);
            return NoContent();


        }

        // DELETE api/<userTypeService>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(String id)
        {


            var userTypeUpdate = userTypeService.Get(id);
            if (userTypeUpdate == null)
            {
                return NotFound($"supplier with id = {id} not found");
            }
            userTypeService.Remove(userTypeUpdate.Id);
            return Ok($"supplier with id = {id} deleted");
        }

    }
}





   
