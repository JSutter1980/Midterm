using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Cars
{
    public class Ferrari : RaceCar
    { 
        public Ferrari()
        {
            Name = "Ferrari";
            TopSpeed = 200;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} rumbles to the starting line!");
        }

        public override void Brake()
        {
            Console.WriteLine($"The {Name} is locking up it's tires!");
            base.Brake();
        }
    }
}