using System;
using System.Collections.Generic;
using System.Text;

namespace _8.CarSalesman
{
   public class Car
    {
        public Car(string model, Engine engine)
        {
            this.Model = model;
            this.Engine = engine;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append($"{Model}:");
            sb.AppendLine();
            sb.AppendLine(Engine.ToString());
            //sb.Append();
            sb.AppendLine(Weight == 0 ? "  Weight: n/a" : $"  Weight: {Weight}");
            //sb.Append();
            sb.AppendLine(String.IsNullOrEmpty(Color) ? "  Color: n/a" : $"  Color: {Color}");
            //sb.Append();
            return sb.ToString().TrimEnd();
        }

        public string Model { get; set; }

        public Engine Engine { get; set; }

        public int Weight { get; set; }

        public string Color { get; set; }
    }
}
