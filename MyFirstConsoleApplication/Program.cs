using System;

namespace MyFirstConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            GetUserNameAndLocation();
            ChristmasCountdown();
            GlazerApp.RunExample();
            Console.WriteLine("Please press a key for ending app.");
            Console.ReadLine();
        }

        private static void GetUserNameAndLocation()
        {
            Person person = new Person();
            Console.WriteLine("What is your name?");
            person.name = Console.ReadLine();
            Console.WriteLine($"Hi {person.name}! Where are you from?");
            person.location = Console.ReadLine();
            Console.WriteLine($"I have never been to {person.location}. I bet it is nice. Press any key to continue...");
            Console.ReadLine();
        }

        private static void ChristmasCountdown()
        {
            Console.WriteLine($"Today's date is: {DateTime.Today.ToShortDateString()} ");
            DateTime today = DateTime.Today;
            DateTime christmas = new DateTime(DateTime.Today.Year, 12, 25);
            String diff2 = (christmas - today).TotalDays.ToString();
            Console.WriteLine($"There are {diff2} days until Christmas!");
            Console.ReadLine();
        }
    }

   
}
