using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Model.OwnerLoginRegistration;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OwnerController
    {
        private readonly IOwnerService ownerTypeService;

        public UserController(IOwnerService ownerService)
        {
            this.ownerTypeService = ownerService;
        }

        // GET: api/<ownerTypeService>
        [HttpGet]
        public ActionResult<List<OwnerRegistration>> Get()
        {
            return ownerTypeService.Get();
        }

        // GET api/<ownerTypeService>/5
        [HttpGet("{id}")]
        public ActionResult<OwnerRegistration> Get(string id)
        {


            var userTypeUpdate = ownerTypeService.Get(id);
            if (userTypeUpdate == null)
            {
                return NotFound($"supplier with id = {id} not found");
            }
            return userTypeUpdate;
        }

        // POST api/<ownerTypeService>
        [HttpPost]
        public ActionResult<OwnerRegistration> Post([FromBody] OwnerRegistration usertypeUpdate)
        {
            ownerTypeService.Create(usertypeUpdate);
            return CreatedAtAction(nameof(Get), new { id = usertypeUpdate.Id }, usertypeUpdate);
        }

        // PUT api/<ownerTypeService>/5
        [HttpPut("{id}")]
        public ActionResult Put(string id, [FromBody] OwnerRegistration usertypeUpdate)
        {
            var existingusertype = ownerTypeService.Get(id);
            if (existingusertype == null)
            {
                return NotFound($"Supplier with id = {id} not found");
            }
            ownerTypeService.Update(id, usertypeUpdate);
            return NoContent();


        }

        // DELETE api/<ownerTypeService>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(String id)
        {


            var userTypeUpdate = ownerTypeService.Get(id);
            if (userTypeUpdate == null)
            {
                return NotFound($"supplier with id = {id} not found");
            }
            ownerTypeService.Remove(userTypeUpdate.Id);
            return Ok($"supplier with id = {id} deleted");
        }

    }
}
}
