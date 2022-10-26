using backend.Model.FuelTypeUpdates;
using backend.Service.FuelTypeUpdates;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class FuelTypeUpdateController : ControllerBase
    {
        private readonly IFuelTypeUpdateService fuelTypeUpdateService;
        public FuelTypeUpdateController(IFuelTypeUpdateService fuelTypeUpdateService)
        {
            this.fuelTypeUpdateService = fuelTypeUpdateService;
        }

        // GET: api/<FuelTypeUpdate>
        [HttpGet]
        public ActionResult<List<FuelTypeUpdate>> Get()
        {
            return fuelTypeUpdateService.Get();
        }

        // GET api/<FuelTypeUpdate>/5
        [HttpGet("{id}")]
        public ActionResult<FuelTypeUpdate> Get(string id)
        {


            var fueltypeupdate = fuelTypeUpdateService.Get(id);
            if (fueltypeupdate == null)
            {
                return NotFound($"supplier with id = {id} not found");
            }
            return fueltypeupdate;
        }

        // GET api/<FuelTypeUpdate>/5
        [HttpGet("getStations/{id}")]
        public ActionResult<FuelTypeUpdate> GetStations(string id)
        {


            var fueltypeupdate = fuelTypeUpdateService.GetStations(id);
            if (fueltypeupdate == null)
            {
                return NotFound($"supplier with id = {id} not found");
            }
            return fueltypeupdate;
        }

        // POST api/<FuelTypeUpdate>
        [HttpPost]
        public ActionResult<FuelTypeUpdate> Post([FromBody] FuelTypeUpdate fuelTypeUpdate)
        {
            fuelTypeUpdateService.Create(fuelTypeUpdate);
            return CreatedAtAction(nameof(Get), new { id = fuelTypeUpdate.Id }, fuelTypeUpdate);
        }

        // PUT api/<FuelTypeUpdate>/5
        [HttpPut("{id}")]
        public ActionResult Put(string id, [FromBody] FuelTypeUpdate fuelTypeUpdate)
        {
            var existingfueltype = fuelTypeUpdateService.Get(id);
            if (existingfueltype == null)
            {
                return NotFound($"Supplier with id = {id} not found");
            }
            fuelTypeUpdateService.Update(id, fuelTypeUpdate);
            return NoContent();


        }

        // DELETE api/<FuelTypeUpdate>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(String id)
        {


            var fuelTypeUpdate = fuelTypeUpdateService.Get(id);
            if (fuelTypeUpdate == null)
            {
                return NotFound($"supplier with id = {id} not found");
            }
            fuelTypeUpdateService.Remove(fuelTypeUpdate.Id);
            return Ok($"supplier with id = {id} deleted");
        }

    }
}





   
