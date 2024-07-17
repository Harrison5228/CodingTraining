using DependencyInjection.SocketAndPlug.Plug.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.SocketAndPlug.Plug
{
    internal class LightPlug : IPlug
    {
        public void Connect()
        {
            Console.WriteLine("Light is connected.");
        }
    }
}
