using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                string[] personData = Console.ReadLine().Split(" ");

                string name = personData[0];
                int age = int.Parse(personData[1]);
                Person currPerson = new Person(name, age);

                people.Add(currPerson);
            }
            List<Person> filterPeopple = people
                .Where(x => x.Age > 30)
                .OrderBy(x => x.Name)
                .ToList();

            foreach (var item in filterPeopple)
            {
                Console.WriteLine($"{item.Name} - {item.Age}");
            }

       
        }
    }
}
