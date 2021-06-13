﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.RawData
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split(" ");
                var engine = new Engine(int.Parse(info[1]), int.Parse(info[2]));
                var cargo = new Cargo(int.Parse(info[3]), info[4]);
                var tires = new []
                {
                    new Tire(double.Parse(info[5]), int.Parse(info[6])),
                    new Tire(double.Parse(info[7]), int.Parse(info[8])),
                    new Tire(double.Parse(info[9]), int.Parse(info[10])),
                    new Tire(double.Parse(info[11]), int.Parse(info[12]))
                };

                cars.Add(new Car(info[0], engine, cargo, tires));

            }

            string type = Console.ReadLine();
            var filtered = new List<Car>();
            if (type == "fragile")
            {
                filtered = cars
                    .Where(c => c.Cargo.Type == "fragile" && c.Tire.Any(t => t.Presure < 1))
                    .ToList();
            }
            else
            {
                filtered = cars
                    .Where(c => c.Cargo.Type == "flamable" && c.Engine.Power > 250)
                    .ToList();
            }
            foreach (Car car in filtered)
            {
                Console.WriteLine(car.Model);
            }

        }
    }
}
