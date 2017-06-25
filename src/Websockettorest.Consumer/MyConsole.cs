namespace Websockettorest.Consumer
{
    using System;

    public class MyConsole : IConsole
    {
        public void WriteLine(string value)
        {
            Console.WriteLine(value);
        }

        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
