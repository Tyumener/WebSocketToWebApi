namespace Websockettorest.Consumer
{
    using DataAccess;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using Phoenix;

    public class Consumer
    {
        private string host;
        private string channelName;
        private IConsole console;
        private IContext context;

        public Consumer(string host, string channelName, IConsole console, IContext context)
        {
            this.host = host;
            this.channelName = channelName;
            this.console = console;
            this.context = context;
        }

        public void Run()
        {            
            // Socket does not implement IDisposable, otherwise I'd have used using here.
            var socket = new Socket(this.host, new SocketOptions() { LogCallback = Logger });
            socket.Connect();
            var channel = socket.Channel(this.channelName, null);
            channel.On("new", (jo, x) => SaveEvent(jo));
            channel.Join();
            this.console.ReadLine();
            socket.Disconnect();
        }        

        private void Logger(string kind, string msg, JObject data = null)
        {
            this.console.WriteLine($"{kind} - {msg}");
        }

        private void SaveEvent(JObject jo)
        {
            var e = jo.ToObject<Event>();
            this.context.Events.Add(e);
        }
    }
}
