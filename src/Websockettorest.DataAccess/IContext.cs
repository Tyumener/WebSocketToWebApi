namespace Websockettorest.DataAccess
{
    using System.Collections.Generic;

    public class IContext
    {
        public IList<Event> Events { get; } = new List<Event>();
    }
}
