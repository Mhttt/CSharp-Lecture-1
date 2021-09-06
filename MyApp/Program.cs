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
            if(IsLeapYear(value)) {
                Console.WriteLine("yay");
            } else {
                Console.WriteLine("nay");
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
