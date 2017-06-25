namespace Websockettorest.Consumer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main(string[] args)
        {
            var host = "wss://machinestream.herokuapp.com/api/v1/events";
            var channelName = "events";
            var consumer = new Consumer(host, channelName, new MyConsole());
            consumer.Run();
        }
    }
}
