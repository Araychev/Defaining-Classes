using System;
using System.Collections.Generic;
using System.Text;

namespace _6.SpeedRacing
{
    public class Car
    {

        public string Model { get; set; }

        public double FuelAmount { get; set; }

        public double FuelConsumptionPerKilometer { get; set; }

        public double Travelleddistance { get; set; }

        public bool Drive(double distanceTraveled)
        {
            double needFuel = distanceTraveled *
                   this.FuelConsumptionPerKilometer;
            if (needFuel > this.FuelAmount)
            {
                return false;
            }
            this.FuelAmount -= needFuel;
            this.Travelleddistance += distanceTraveled;
            return true;
        }
    }
}
