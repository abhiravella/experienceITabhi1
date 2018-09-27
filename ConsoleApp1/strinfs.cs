using System;

namespace ConsoleApp1
{
    public class strings
    {
        public void one()
        {
            Console.WriteLine("Enter numbers separated by '-'");
            var input = Console.ReadLine();
            if (String.IsNullOrEmpty(input) || String.IsNullOrWhiteSpace(input))
                return;
            var numbs = input.Split('-');
            var cnt = numbs.Length;
            var flag = false;
            for (var i = 0; i < cnt; i++)
            {
                if (i != cnt-1)
                {
                    var temp = Convert.ToInt32(numbs[i]);
                    var temp2 = Convert.ToInt32(numbs[i + 1]);
                    if ((temp2 - temp) == 1) { 
                        flag = true;
                    }
                }
                flag = false;
                break;                
            }

            if (flag){
                Console.WriteLine("Consecutive numbers");
            }
            else{
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
                Console.WriteLine("Invalid input");
            }
            else
            {
                var tempHours = 0;
                var tempMinutes = 0s;
                try
                {
                    tempHours = Convert.ToInt32(time[0]);
                    tempMinutes = Convert.ToInt32(time[1]);
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Invalid Input:");
                    return;
                }
                if(tempMinutes > 0 && tempMinutes < 59) { 
                    if (tempHours > 0 && tempHours < 24)
                    {
                        Console.WriteLine("Valid input");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid ");
                }
            }

        }
    }
}