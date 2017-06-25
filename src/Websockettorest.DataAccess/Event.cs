using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Websockettorest.DataAccess
{
    public class Event
    {
        public string MachineId { get; set; }
        public string Id { get; set; }
        public DateTime Timestamp { get; set; }
        public EventStatus Status { get; set; }
    }
}
