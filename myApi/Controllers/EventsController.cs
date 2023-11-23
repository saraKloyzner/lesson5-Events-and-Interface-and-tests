using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace myApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly IDataCotext _context;
        public EventsController(IDataCotext context)
        {
            _context = context;
        }
           
        // GET: api/<EventsController>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_context.Events);
        }

        // GET api/<EventsController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var temp = _context.Events.Find(e => e.Id == id);
            if(temp ==null)
                return NotFound();
            return Ok(temp);


        }

        // POST api/<EventsController>
        [HttpPost]
        public void Post([FromBody] Event eve)
        {
            int id = 10;
            eve.Id =id++ ;
            _context.Events.Add(eve);
            
        }

        // PUT api/<EventsController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Event eve)
        {
            var temp = _context.Events.Find(e => e.Id == id);
            if (temp == null)
                return Unauthorized();
            temp.Title = eve.Title;
            temp.Start = eve.Start;
            temp.End=eve.End;
            return Ok(temp);
        }

       

        // DELETE api/<EventsController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var temp = _context.Events.Find(e => e.Id == id);
            if (temp == null)
                return BadRequest();
            return Ok(_context.Events.Remove(temp));
        }
    }
}
