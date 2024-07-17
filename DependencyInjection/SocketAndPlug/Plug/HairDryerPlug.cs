using DependencyInjection.SocketAndPlug.Plug.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.SocketAndPlug.Plug
{
    internal class HairDryerPlug : IPlug
    {
        public void Connect()
        {
            Console.WriteLine("HairDryer is connected.");
        }
    }
}
