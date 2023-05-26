using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            

          

            // Create a list of Vehicle called vehicles
            var vehicle = new List<Vehicle>();
            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties with object initializer syntax
             */
            Car RS200 = new Car() { HasTrunk = false, make = "Ford", model = "RS 200", year = 1988, };
            Motorcycle PanigaleV4R = new Motorcycle() { HasSideCar = false, make = "Ducati", model = "Panigale V4 R", year = 2023, };
            Vehicle Rav4 = new Car() { HasTrunk = false, make = "Toyota", model = "Rav 4", year = 2023, };
            Vehicle Jetta = new Car() { HasTrunk = true, year = 2010, make = "VW", model = "Jetta" };
            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */
            vehicle.Add(RS200 );
            vehicle.Add(PanigaleV4R );
            vehicle.Add(Rav4 );
            vehicle.Add(Jetta );

            foreach (var Car in vehicle )
            {
                Console.WriteLine($"{Car.year }, {Car.make }, {Car.model }");
                Car.DriveAbstract();
                Console.WriteLine("_____________________");
                Console.WriteLine();
            }
            // Call each of the drive methods for one car and one motorcycle

            #endregion            
           
        }
    }
}
