using System;

namespace ConsoleApplication
{
    public class Program
    {

        public static string speak(string s1, string s2, string intensity = "")
        {
            string output = $"{s1}, {s2}.";
            if (intensity == "loud")
            {
                output = output.ToUpper().Replace(".", "!");
            }
            else if (intensity == "quiet")
            {
                output = output.ToLower().Replace(".", "...");
            }
            return output;
        }

        public static void string_tests()
        {
            var greeting = "Welcome back";
            var name = "Agent Cooper";
            var combined = greeting + ", " + name + ".";
            Console.WriteLine(combined);
            Console.WriteLine(combined.Replace(name, "BOB"));
            Console.WriteLine($"{greeting} to string interpolation, {name}! Apparently this has the best performance.");
            // NOTE: Substring parameters are (starting index, length of substring)
            Console.WriteLine(combined.ToUpper().Substring(20, 4));

            Console.WriteLine(speak(greeting, name));
            Console.WriteLine(speak(greeting, name, "loud"));
            Console.WriteLine(speak(greeting, name, "quiet"));
            Console.WriteLine(speak(greeting, name, "dumb"));
        }

        public static void days_old(DateTime birthday)
        {
            TimeSpan days_old = DateTime.Now - birthday;
            // NOTE: Casting from double to int is done as below
            Console.WriteLine($"You are {(int)days_old.TotalDays} days old.");
            double days_to_next_anniversary = 10000 - (days_old.TotalDays % 10000);
            Console.WriteLine($"It's {(int)days_to_next_anniversary} days until your next 10000 day anniversary.");
        }

        public static void datetime_tests()
        {
            var currentTime = DateTime.Now;
            var today = DateTime.Today;
            var someDate = new DateTime(2017,3,29);
            var someMoment = new DateTime(1984,3,29,21,11,0);
            var yesterday = DateTime.Today.AddDays(-1);
            var someDay = DateTime.Parse("1/1/2017");
            
            Console.WriteLine($"currentTime = {currentTime}");
            Console.WriteLine($"today = {today}");
            Console.WriteLine($"someDate = {someDate}");
            Console.WriteLine($"someMoment = {someMoment}");
            Console.WriteLine($"yesterday = {yesterday}");
            Console.WriteLine($"someDay = {someDay}");
            Console.WriteLine($"someMoment.Hour = {someMoment.Hour}");

            DateTime nextYear = new DateTime(DateTime.Today.Year + 1, 1, 1);
            TimeSpan duration = nextYear - DateTime.Today;
            Console.WriteLine($"There are {duration.TotalDays} days left in the year.");

            days_old(someMoment);
        }

        public static void Main()
        {
            string_tests();
            datetime_tests();
        }
    }
}
