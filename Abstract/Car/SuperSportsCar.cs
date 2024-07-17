using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.Car
{
    internal class SuperSportsCar : Car
    {
        public new int numberOfWheels = 8;
        public new string color = "Red";

        public override string OpenDoor()
        {
            return "Open door from top";
        }

        public override string Run()
        {
            return "Super Sports Car is Running.";
        }
    }
}
