using System;

namespace ConsoleApp1
{
    public class strings
    {
        public void one()
        {
            Console.WriteLine("Enter numbers separated by '-'");
            var input = Console.ReadLine();
            if (string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input))
            {
                return;
            }

            var numbs = input.Split('-');
            var cnt = numbs.Length;
            var flag = false;
            for (var i = 0; i < cnt; i++)
            {
                if (i != cnt - 1)
                {
                    var temp = Convert.ToInt32(numbs[i]);
                    var temp2 = Convert.ToInt32(numbs[i + 1]);
                    if ((temp2 - temp) == 1)
                    {
                        flag = true;
                    }
                }
                flag = false;
                break;
            }

            if (flag)
            {
                Console.WriteLine("Consecutive numbers");
            }
            else
            {
                Console.WriteLine("Non Consecutive numbers");
            }
        }

        public void two()
        {
            Console.WriteLine("Enter time in 24 hour format (19:00) or press enter ");
            var userInput = Console.ReadLine();
            var time = userInput.Split(':');
            if (time.Length > 2 || time.Length == 0)
            {
                Console.WriteLine("Invalid input. The input should ");
            }
            else
            {
                var tempHours = 0;
                var tempMinutes = 0;
                try
                {
                    tempHours = Convert.ToInt32(time[0]);
                    tempMinutes = Convert.ToInt32(time[1]);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Input:");
                    return;
                }
                if (tempMinutes > 0 && tempMinutes < 59)
                {
                    if (tempHours > 0 && tempHours < 24)
                    {
                        Console.WriteLine("Valid input");
                    }
                    else
                    {
                        Console.WriteLine("Invalid Hours");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Minutes");
                }
            }
        }

        public void three()
        {
            Console.WriteLine("Enter a word or string or press Enter to exit");
            var userInput = Console.ReadLine();
            var vowelCount = 0;
            vowelCount = (userInput.Length - userInput.Replace("a", "").Replace("e", "").Replace("i", "").Replace("o", "").Replace("u", "").Length);
            Console.WriteLine("Number of Vowels is "+vowelCount);
        }
    }
}