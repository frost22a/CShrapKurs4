using System;

namespace _1_Array
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] monthsOfYear =
            {
                "January",
                "Febrry",
                "March",
                "April",
                "May",
                "June",
                "July",
                "August",
                "September",
                "October",
                "November",
                "December"
            };

            Console.WriteLine("Before editing: ");

            foreach (var month in monthsOfYear)
                Console.WriteLine(month);           

            monthsOfYear[1] = "February";

            Console.WriteLine("\nAfter editing: ");

            foreach (var month in monthsOfYear)
                Console.WriteLine(month);
        }
    }
}
