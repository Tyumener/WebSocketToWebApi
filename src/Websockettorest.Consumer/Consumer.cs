namespace Websockettorest.Consumer
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class Consumer
    {
        private string host;
        private string channelName;
        private IConsole console;

        public Consumer(string host, string channelName, IConsole console)
        {
            this.host = host;
            this.channelName = channelName;
            this.console = console;
        }

        public void Run()
        {
            var socket = new PhoenixSocket.Socket(this.host,
                logger: (kind, msg, data) => this.console.WriteLine($"{kind}: {msg}, \n" + JsonConvert.SerializeObject(data)));

            socket.Connect();

            var channel = socket.Channel(this.channelName);            
            channel.On("new_msg", msg =>
            {
                this.console.WriteLine("New message: " + JsonConvert.SerializeObject(msg));
            });
            channel.Join();
            
            this.console.ReadLine();       

            channel.Leave();
            socket.Disconnect(null);
        }
    }
}
