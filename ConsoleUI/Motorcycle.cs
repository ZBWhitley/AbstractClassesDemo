using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {
        public override void DriveAbstract()
        {
            Console.WriteLine("Does drive");
        }        
        bool HasSideCar;
        public override void DriveVirtual()
        {
            base.DriveVirtual();
        }
    }
}
