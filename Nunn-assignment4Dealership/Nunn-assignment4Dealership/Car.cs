using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Nunn_assignment4Dealership
{
    public class Car : Vehicle

    {
        public new void Drive() => WriteLine($"{name} has just been waxed.");
        public Car(string newName) : base(newName) { }

        public override void MakeNoise()
        {
            WriteLine($"{name} says Rumble!");
        }
    }
}
