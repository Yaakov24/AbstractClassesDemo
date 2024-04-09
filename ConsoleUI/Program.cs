using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo: Follow all comments!! 
             * Double click on the region (gray box) to view all comments
             */



            #region Vehicles

            Car car = new Car()
            { HasTrunk = true,
                Make = "Aston Martin",
                Model = "aldkjla",
                Year = 2024
         };
           
        Motorcycle motorcycle = new Motorcycle()
         {  
              Make = "Motorcycle",
              Model = "X898686",
              Year = 2019
         };
      

         Vehicle vehicle1 = new Car() 
         {
             HasTrunk = true, 
             Make = "Toyota", 
             Model = "aldkjla",
             Year = 2024 
         };

        Vehicle vehicle2 = new Motorcycle() 
         { 
            Make = "Humvee", 
            Model = "aldkjla", 
            Year = 2024 
         };
       
     List<Vehicle> vehicles = new List<Vehicle>();

            vehicles.Add(car);
            vehicles.Add(motorcycle);
            vehicles.Add(vehicle1);
            vehicles.Add(vehicle2);
     
            foreach (var item in vehicles)
            {
                Console.WriteLine($"Make:{item.Make} Model:{item.Model} Year:{item.Year}");
                item.DriveAbstract();
                item.DriveVirtual();
                Console.WriteLine();
            }
            


            /*
             * Create an abstract class called Vehicle done
             * The vehicle class shall have three string properties: Year, Make, and Model done
             * Set the defaults of the properties to something generic in the Vehicle class done
             * Vehicle class shall have an abstract method called DriveAbstract with no implementation. done
             * Vehicle class shall have a virtual method called DriveVirtual with a base implementation. done
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle done
             * Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle done
             * Provide the implementations for the abstract methods done
             * Only in the Motorcycle class will you override the virtual drive method done
            */

            // Create a list of Vehicle called vehicles done

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes done
             * 
             * Set the properties values with object initializer syntax done
             */

            /*
             * Add the 4 vehicles to the list done
             * Using a foreach loop iterate through the list and display each of the properties done
             */

            // Call each of the drive methods for one car and one motorcycle

            #endregion
            Console.ReadLine();
        }
    }
}
