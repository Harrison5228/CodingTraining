using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.Car
{
    abstract class Car
    {
        public int numberOfWheels = 4;
        public string color = "Black";

        public virtual string OpenDoor()
        {
            return "Open door from side";
        }

        public abstract string Run();
    }
}
