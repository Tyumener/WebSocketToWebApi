namespace Websockettorest.Webapi.Controllers
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using DataAccess;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;

    [Route("api/[controller]")]
    public class EventsController : Controller
    {
        private Context context; 

        public EventsController(Context context)
        {
            this.context = context;
        }

        // GET api/values
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var events = await this.context.Events.ToListAsync();
            return this.Ok(events);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            var requestedEvent = await this.context.Events.SingleOrDefaultAsync(e => e.Id == id);

            if (requestedEvent == null) return this.NotFound();
                        
            return this.Ok(requestedEvent);
        }        
    }
}
