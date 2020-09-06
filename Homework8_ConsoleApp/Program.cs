using Homework8_ConsoleApp.Task4;
using Homework8_ConsoleApp.Task5;
using System;
using System.Collections.Generic;

namespace Homework8_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //task4
            Database.items.Add(new RawMaterial("20kg", "Sugar"));

            foreach (var i in Database.items)
            {
                Console.WriteLine(i.Name);
            }
            Database.items.Add(new Furniture("Ikea", "Chair"));

            foreach (var i in Database.items)
            {
                Console.WriteLine(i.Name);
            }
            Console.ReadLine();

            //task5
            List<Flower> flowers = new List<Flower>();
            double Sum = 0;
            flowers.Add(new Rose());
            flowers.Add(new Rose());
            flowers.Add(new Rose());
            flowers.Add(new Tulip());
            flowers.Add(new Carnation());

            foreach (var i in flowers)
            {
                Sum += i.Price;
            }

            Console.WriteLine("Total price of the flowers: " + Sum);
            Console.ReadLine();
        }
    }
}
