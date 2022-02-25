using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public override void DriveAbstract() { }
        public override void DriveVirtual()
        {
            Console.WriteLine("This car is operational.");
        }              

        public bool HasTrunk { get; set; }
    }
}
