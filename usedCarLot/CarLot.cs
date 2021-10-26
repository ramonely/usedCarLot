using System;
using System.Collections.Generic;
using System.Text;

namespace usedCarLot
{
    internal class CarLot
    {
        private List<Car> buyNow = new List<Car>();

        public CarLot()
        {
            buyNow.Add(new Car("VW", "GTI", 2009, 8999));
            buyNow.Add(new Car("BMW", "M3", 2012, 59999));
            buyNow.Add(new Car("KIA", "K6", 2020, 46599));
            buyNow.Add(new UsedCar("VW", "Golf", 2002, 14999, 13596));
            buyNow.Add(new UsedCar("Dodge", "Dart", 2016, 34999, 212));
            buyNow.Add(new UsedCar("Tesla", "Model 3", 2011, 43999, 1234));
        }

        public void ManageCar()
        {
            Console.WriteLine("What is the password?");
            string pass = Console.ReadLine();
            if (pass == "password")
            {
                Console.WriteLine("Do you want to add or remove a car?");
                string choice = Console.ReadLine();
                if (choice == "add")
                {
                    Console.WriteLine("What is the Make of the car?");
                    string ma = Console.ReadLine();
                    Console.WriteLine("What is the Model of the car?");
                    string mo = Console.ReadLine();
                    Console.WriteLine("What is the Year of the car?");
                    int ye = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("How much are you selling the car for?");
                    decimal pr = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Is the car new or used?");
                    string answer = Console.ReadLine();
                    if (answer == "new")
                    {
                        buyNow.Add(new Car(ma, mo, ye, pr));
                        Console.WriteLine("Car has been added to the lot");
                    }
                    else if (answer == "used")
                    {
                        Console.WriteLine("What is the Miles of the car?");
                        double mi = Convert.ToDouble(Console.ReadLine());
                        buyNow.Add(new UsedCar(ma, mo, ye, pr, mi));
                        Console.WriteLine("\nCar has been added to the lot");
                    }
                }
                else if (choice == "remove")
                {
                    Console.WriteLine("\nWhich car do you want to remove?\n");
                    ListCars();
                    Console.Write("\nEnter Car ID: ");
                    int car = Convert.ToInt32(Console.ReadLine());
                    buyNow.RemoveAt(car);
                    Console.WriteLine("\nCar as been removed");
                }
            }
            else
            {
                Console.WriteLine("\nLEAVE NOW!");
            }
            Console.WriteLine();
            Menu();
        }

        public void ListCars()
        {
            Console.WriteLine("Car ID\tMake\tModel\t\tYear\tPice");
            Console.WriteLine("-------------------------------------------------------");
            for (int i = 0; i < buyNow.Count; i++)
            {
                Car c = buyNow[i];
                Console.WriteLine($"<{i}>\t{c.Make}\t{c.Model}\t\t{c.Year}\t${c.Price}");
            }
        }

        public void Sold()
        {
            Console.WriteLine("Which car do you want to buy?\n");
            ListCars();
            Console.Write("\nEnter a Car ID: ");
            int answer1 = Convert.ToInt32(Console.ReadLine());
            if (answer1 <= buyNow.Count)
            {
                Car c = buyNow[answer1];

                Console.WriteLine($"\nCongrats on buying a {c.Make} {c.Model} {c.Year} for ${c.Price}!");
                buyNow.RemoveAt(answer1);
                Console.WriteLine();
                Menu();
            }
            else
            {
                Console.WriteLine("Only enter a Car ID listed");
            }
        }

        public void Menu()

        {
            Console.WriteLine("What would would you like to do?\n");
            Console.WriteLine("1) Manage cars");
            Console.WriteLine("2) View all cars");
            Console.WriteLine("3) Leave");
            Console.WriteLine("4) Search by Make");
            Console.Write("\nEnter 1-4: ");
            string answer = Console.ReadLine();
            if (answer == "1")
            {
                Console.WriteLine();
                ManageCar();
                Console.WriteLine();
            }
            else if (answer == "2")
            {
                Console.WriteLine();
                Sold();
                Console.WriteLine();
            }
            else if (answer == "3")
            {
                Console.WriteLine();
                Console.WriteLine("Goodbye!");
            }
            else if (answer == "4")
            {
                Console.Write("Enter a Make you are looking for: ");
                string make = Console.ReadLine().ToLower();
                for (int i = 0; i < buyNow.Count; i++)
                {
                    Car w = buyNow[i];
                    if (make == w.Make.ToLower())
                    {
                        Console.WriteLine($"\nCongrats we have a {w.Make} {w.Model} {w.Year} for ${w.Price}!\n");
                        Menu();
                    }
                }
                for (int i = 0; i < buyNow.Count; i++)
                {
                    Car w = buyNow[i];
                    if (make != w.Make.ToLower())
                    {
                        Console.WriteLine("\nWe dont have any of those.\n");
                        Menu();
                    }
                }
            }
        }
    }
}