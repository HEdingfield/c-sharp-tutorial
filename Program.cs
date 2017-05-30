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

        public static void Main()
        {
            string_tests();
        }
    }
}
