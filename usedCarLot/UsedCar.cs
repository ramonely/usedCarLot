using System;
using System.Collections.Generic;
using System.Text;

namespace usedCarLot
{
    internal class UsedCar : Car
    {
        public double Miles { get; set; }

        public UsedCar(string make, string model, int year, decimal price, double miles) : base(make, model, year, price)
        {
            Miles = miles;
        }

        public override void CarInfo()
        {
            Console.WriteLine($"Congrats on buying a {Make} {Model} {Year} for ${Price} with {Miles}!");
        }
    }
}