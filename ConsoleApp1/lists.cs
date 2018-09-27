using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;

namespace ConsoleApp1
{
    public class lists
    {
        public void DisplayNameAttribute()
        {
            var listNames = new List<string>();
            var Name="";
            Console.WriteLine("Enter names of your friends");
            do
            {
                listNames.Add(Name);
                Name = Console.ReadLine();
            } while (!(String.IsNullOrEmpty(Name) || String.IsNullOrWhiteSpace(Name)));

            var count = listNames.Count;
            switch (count)
            {
                case 1: Console.WriteLine( " No likes yet.....");
                    break;
                case 2 : Console.WriteLine(" {0} likes your post ",listNames[1]);
                    break;
                case 3: Console.WriteLine( "{0} and {1} likes your post ",listNames[1],listNames[2]);
                    break;
                default: Console.WriteLine("{0} , {1} and {2} other liked your post",listNames[1],listNames[2],listNames.Count -3);       
                    break;
            }
        }
        public void DisplayNameAttributetwo()
        {
            var listNames = new List<string>();
            var Name = "";
            do
            {
                Console.WriteLine("Enter your friends name or press enter when you are done");
                listNames.Add(Name);
                Name = Console.ReadLine();
            } while (!(String.IsNullOrEmpty(Name) || String.IsNullOrWhiteSpace(Name)));

            var count = listNames.Count;
            switch (count)
            {
                case 1:
                    Console.WriteLine(" No likes yet.....");
                    break;
                case 2:
                    Console.WriteLine(" {0} likes your post ", listNames[1]);
                    break;
                case 3:
                    Console.WriteLine("{0} and {1} likes your post ", listNames[1], listNames[2]);
                    break;
                default:
                    Console.WriteLine("{0} , {1} and {2} other liked your post", listNames[1], listNames[2], listNames.Count - 3);
                    break;
            }
        }

        public void reversal()
        {
            Console.WriteLine("Enter your name");
            var name = Console.ReadLine().ToCharArray();
            Array.Reverse(name);
            var revname = new string(name);
            Console.WriteLine(revname);
        }

        public void numbers()
        {
            Console.WriteLine("Enter 5 unique numbers");
            var numbers =  new List<int>();
            var count = 0;
            while (count < 5)
            {                
                var tempString = Console.ReadLine();
                if(String.IsNullOrEmpty(tempString)||String.IsNullOrWhiteSpace(tempString))
                    continue;          
                var temp = Convert.ToInt32(tempString);
                if (numbers.Contains(temp))
                {
                    Console.WriteLine("{0} has already been entered. Try a different number",temp);
                    continue;
                }
                numbers.Add(temp);
                count++;
            }

            Console.WriteLine("Entered numbers are....");
            foreach (var num in numbers)
            {
                Console.WriteLine("{0}",num);
            }
        }

    }
}