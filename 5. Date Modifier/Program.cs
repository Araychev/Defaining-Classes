using System;

namespace _5._Date_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();

            int days = DateModifier.GetDiffBetweenDatesInDays(firstDate, secondDate);

            Console.WriteLine(days);
        }


    }
}
