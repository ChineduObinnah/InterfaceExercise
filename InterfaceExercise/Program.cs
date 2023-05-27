using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */
            

            var subaru = new Car();
            subaru.Leather = false;
            subaru.moonroof = true;
            subaru.Name = "Subaru";
            subaru.Revenue = 80;
            subaru.Airbags = true;
            subaru.Wheels = 4;
            subaru.Name = "Subaru";

            var gmc = new Truck();
            gmc.Age = 70;
            gmc.Revenue = 60; 
            gmc.Airbags = true;
            gmc.Wheels = 4;
            gmc.Logo = "GMC";
            gmc.FourWheelDrive = true;
            gmc.Wheels = 4;
            gmc.Name = "GMC";

            var jeep = new SUV();
            jeep.AWD = true;
            jeep.ThirdRowSeats = false;
            jeep.Wheels = 4;
            jeep.Age = 90;
            jeep.Airbags = true;
            jeep.Revenue = 70;
            jeep.Motto = " Zoom Zoom";
            jeep.Wipers = true;
            jeep.Name = "Jeep";
            var parkingLot = new List<IVehicle>() { subaru, gmc, jeep };

            foreach( var vehicle in parkingLot) 
            {
                Console.WriteLine($" Name {vehicle.Name} \n Has Airbags {vehicle.Airbags}\n Number of Wheels {vehicle.Wheels}\n Has Wipers {vehicle.Wipers}\n");
            }



            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
        }
    }
}
