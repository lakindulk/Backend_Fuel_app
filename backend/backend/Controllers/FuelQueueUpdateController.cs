using backend.Model;
using backend.Service;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuelQueueUpdateController : ControllerBase
    {
        private readonly IFuelQueueUpdateService queueService;

        public FuelQueueUpdateController(IFuelQueueUpdateService updateService) {
            this.queueService = updateService;
        }

        // GET: api/<FuelQueueUpdateController>
        [HttpGet]
        public ActionResult<List<FuelQueueUpdate>> Get()
        {
            return queueService.Get();
        }

        // GET api/<FuelQueueUpdateController>/5
        [HttpGet("{id}")]
        public ActionResult<FuelQueueUpdate> Get(string id)
        {
            var queue = queueService.Get(id);
            if (queue == null)
            {
                return NotFound($"customer with id = {id} not found");
            }
            return queue;
        }

        // POST api/<FuelQueueUpdateController>
        [HttpPost]
        public ActionResult<FuelQueueUpdate> Post([FromBody] FuelQueueUpdate value)
        {
            queueService.Create(value);
            return CreatedAtAction(nameof(Get), new { id = value.Id }, value);
        }

        // PUT api/<FuelQueueUpdateController>/5
        [HttpPut("{id}")]
        public ActionResult Put(string id, [FromBody] FuelQueueUpdate value)
        {
            var existingcustomer = queueService.Get(id);
            if (existingcustomer == null)
            {
                return NotFound($"Customer with id = {id} not found");
            }
            queueService.Update(id, value);
            return NoContent();
        }

        // DELETE api/<FuelQueueUpdateController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            var queue = queueService.Get(id);
            if (queue == null)
            {
                return NotFound($"Customer with id = {id} not found");
            }
            queueService.Remove(queue.Id);
            return Ok($"Customer with id = {id} deleted");
        }
    }
}
