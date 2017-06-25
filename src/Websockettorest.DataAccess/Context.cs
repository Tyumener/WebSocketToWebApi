using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Websockettorest.DataAccess
{
    public class Context
    {
        public IList<Event> Events { get; } = new List<Event>();
    }
}
