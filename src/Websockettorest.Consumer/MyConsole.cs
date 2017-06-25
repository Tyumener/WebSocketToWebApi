using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Websockettorest.Consumer
{
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
