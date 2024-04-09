using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {
        public int HasTrunk { get; set; } = 2;

        public override void DriveAbstract()
        {
            Console.WriteLine("Driving a motorcycle with an abstract method.");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine("Has two wheels with a virtual Method");
        }
    }
}
