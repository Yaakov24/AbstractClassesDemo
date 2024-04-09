using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal abstract class Vehicle
    {


        public int Year { get; set; } = 2024;
        public string Make { get; set; } = "Generic Make";
        public string Model { get; set; } = "Normal Car";
       
        public abstract void DriveAbstract();
       public virtual void DriveVirtual()
        {
            Console.WriteLine("Driving a vehicle from a virtual method");
        }
    }
}
