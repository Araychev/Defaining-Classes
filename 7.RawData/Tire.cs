using System;
using System.Collections.Generic;
using System.Text;

namespace _7.RawData
{
   public class Tire
    {

        public Tire(double presure, int age)
        {
            this.Presure = presure;
            this.Age = age;
        }

        public double Presure { get; set; }

        public int Age { get; set; }
    }
}
