namespace Websockettorest.Consumer
{
    using DataAccess;

    public class Program
    {
        public static void Main(string[] args)
        {
            var host = "wss://machinestream.herokuapp.com/api/v1/events";
            var channelName = "events";
            var consumer = new Consumer(host, channelName, new MyConsole(), new Context());
            consumer.Run();
        }
    }
}
