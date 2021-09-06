using System;

namespace MyApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a year not earlier than 1582:");
            string input = Console.ReadLine();
            int value = int.Parse(input);

            //TryParse tager først string inputtet, og den variabel den konverterede string skal sættes til
            bool success = int.TryParse(input, out value);

            if(!success || value < 1582) {
                Console.WriteLine("Please enter a valid real number, larger than 1582");
            }
            if(success && value >= 1582) {
                if(IsLeapYear(value)) {
                Console.WriteLine("yay");
            } else {
                Console.WriteLine("nay");
            }
            }
        }

        public static bool IsLeapYear(int year) {

            if(year % 100 == 0 && year % 400 != 0) {
                return false;
            } else if (year % 4 == 0) {
                return true;
            } else {
                return false;
            }
        }
    }

}
