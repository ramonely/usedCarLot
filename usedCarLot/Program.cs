using System;
using System.Collections.Generic;
using System.Text;

namespace usedCarLot
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            CarLot Sales = new CarLot();
            Console.WriteLine("WELCOME TO MEGA CARS!!!!\n");
            Sales.Menu();
        }
    }
}