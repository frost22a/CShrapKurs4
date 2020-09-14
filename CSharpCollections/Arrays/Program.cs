using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            // inicjalizacja najprostszej tablicy, gdy z góry znamy jakie rekordy będą w niej zawarte 
            string[] monthOfYear =
            {
                "January",
                "february",
                "March",
                "April",
                "May",
                "June",
                "July",
                "August",
                "September",
                "Optober",
                "November",
                "December"
            };

            #region array examples
            int[] arrayInt = {4, 77 ,24,36 };
            char[] arrayChar = { 'g', 'l', 'a', 's' };
            System.Drawing.Rectangle[] arrayRectangle =
                {
                    new System.Drawing.Rectangle(10,10,50,50),
                    new System.Drawing.Rectangle(20,30,440,60),
                    new System.Drawing.Rectangle(10,40,150,250)
                };
            #endregion

            #region foreach in arrays
            //foreach pozwala przejść przez każdy element kolekcji
            foreach (var month2 in monthOfYear)
            {
                Console.WriteLine(month2);
            }
            #endregion

            #region display months using array
            Console.WriteLine("Which month do You Want to display (1 - January, 2 - february, etc.)");
            int month = int.Parse(Console.ReadLine());
            string chosenMonth = monthOfYear[month-1];


            Console.WriteLine($"You choose: {monthOfYear}");
            #endregion

            #region editing arrays

            monthOfYear[1] = "February";

            #endregion

        }
    }
}
