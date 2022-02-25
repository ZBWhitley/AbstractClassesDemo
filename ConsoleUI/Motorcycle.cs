using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public override void DriveAbstract(){}       
        
        public override void DriveVirtual()
        {
            Console.WriteLine("This motorcycle is not operational.");
        }
        public bool HasSideCar { get; set; }
    }
}
