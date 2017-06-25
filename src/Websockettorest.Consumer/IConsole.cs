using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Websockettorest.Consumer
{
    public interface IConsole
    {
        void WriteLine(string value);
        string ReadLine();
    }
}
