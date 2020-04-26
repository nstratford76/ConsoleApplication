using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name? \n");
            string name = Console.ReadLine();

            Console.WriteLine("Where do you live? \n");
            string location = Console.ReadLine();

            Console.WriteLine("My name is " + name + " and I live in " + location + "\n");

            string date = DateTime.UtcNow.ToString("MM-dd-yyyy");

            DateTime currentDate = DateTime.Now;

            Console.WriteLine("The current date is {0}", date);

            var christmas = new DateTime(2020, 12, 25);

            var span = christmas - currentDate;

            var daysToChristmas = span.Days;

            Console.WriteLine("There are " + daysToChristmas + " days until Christmas\n");



        } 
    }
}
