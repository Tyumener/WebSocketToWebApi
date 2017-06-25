namespace Websockettorest.Webapi.Controllers
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using DataAccess;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;
    using System.Linq;

    [Route("api/[controller]")]
    public class EventsController : Controller
    {
        private Context context; 

        public EventsController(Context context)
        {
            this.context = context;
        }

        // Also custom sorting and paging might be added here, but for that it would be
        // necessary to create a separate resource for storing data snapshots
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var events = await this.context.Events.OrderByDescending(e => e.Timestamp).ToListAsync();
            
            return this.Ok(events);
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            var requestedEvent = await this.context.Events.SingleOrDefaultAsync(e => e.Id == id);

            if (requestedEvent == null) return this.NotFound();
                        
            return this.Ok(requestedEvent);
        }        
    }
}
