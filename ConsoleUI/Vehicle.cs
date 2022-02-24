using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        string Year;
        string Make;
        string Model;

        public abstract void DriveAbstract();
        public virtual void DriveVirtual() 
        {
            Console.WriteLine();
        }
    }
}
