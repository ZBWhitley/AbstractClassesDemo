﻿using System;
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
            var vehicles = new List<Vehicle>();

            var c1 = new Car();
            c1.Year = 2003;
            c1.Make = "Subaru";
            c1.Model = "WRX";
            c1.HasTrunk = true;            
            vehicles.Add(c1);            

            var m1 = new Motorcycle();
            m1.Year = 2022;
            m1.Make = "Suzuki";
            m1.Model = "Hayabusa";
            m1.HasSideCar = false;
            vehicles.Add(m1);

            Vehicle c2 = new Car() {Year = 2013, Make = "Hyundai", Model = "Sonata", HasTrunk = true};
            //c2.Year = 2013;
            //c2.Make = "Hyundai";
            //c2.Model = "Sonata";
            //c2.HasTrunk = true;
            vehicles.Add(c2);

            Vehicle m2 = new Motorcycle() {Year = 2015, Make = "Suzuki", Model = "GSX-R", HasSideCar = false};
            //m2.Year = 2015;
            //m2.Make = "Suzuki";
            //m2.Model = "GSX-R";
            //m2.HasSideCar = false;
            vehicles.Add(m2);

            foreach (var vehicle in vehicles) 
            {
                Console.WriteLine($"Year: {vehicle.Year} Make: {vehicle.Make} Model: {vehicle.Model}");
                vehicle.DriveVirtual();
                Console.WriteLine();
            }



            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            // Call each of the drive methods for one car and one motorcycle

            #endregion            
        }
    }
}
