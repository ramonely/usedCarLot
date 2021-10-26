using System;
using System.Collections.Generic;
using System.Text;

namespace usedCarLot
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }

        public Car(string make, string model, int year, decimal price)
        {
            Make = make;
            Model = model;
            Year = year;
            Price = price;
        }

        public virtual void CarInfo()
        {
            Console.WriteLine($"Congrats on buying a {Make} {Model} {Year} for ${Price}!");
        }
    }
}