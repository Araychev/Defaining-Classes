using System;
using System.Collections.Generic;
using System.Text;

namespace _8.CarSalesman
{
    public class Engine
    {

        public Engine(string model, int power)
        {
            this.Model = model;
            this.Power = power;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.Append($"  {Model}:");
            sb.AppendLine();
            sb.AppendLine($"    Power: {Power}");
            sb.AppendLine(Displacement == 0 ? "    Displacement: n/a" : $"    Displacement: {Displacement}");
            sb.AppendLine(String.IsNullOrEmpty(Efficiency)? "    Efficiency: n/a" :  $"    Efficiency: {Efficiency}");

            return sb.ToString().TrimEnd();
        }
        public string Model { get; set; }

        public int Power { get; set; }

        public int Displacement { get; set; }

        public string Efficiency { get; set; }
    }
}
