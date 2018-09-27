using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             *  Sep 18
             */

            /*
                Console.WriteLine("Enter two numbers");
                var num_1 = Convert.ToInt32(Console.ReadLine());
                var num_2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Sum is "+(num_1+num_2));

                Console.WriteLine("Enter three numbers");
                num_1 = Convert.ToInt32(Console.ReadLine());
                num_2 = Convert.ToInt32(Console.ReadLine());
                var num_3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Multiplication is "+(num_1*num_2*num_3));
                Console.WriteLine("Enter a number");
                num_1 = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(String.Format("{0} * {1} = {2}",num_1,i,num_1*i));
                }

                Console.WriteLine("Enter four numbers");
                num_1 = Convert.ToInt32(Console.ReadLine());
                num_2 = Convert.ToInt32(Console.ReadLine());
                num_3 = Convert.ToInt32(Console.ReadLine());
                var num_4 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(String.Format("The average of four numbers is {0}",(num_4+num_1+num_2+num_3)/4.0));    

                Console.WriteLine("Enter a number");
                num_1 = Convert.ToInt32(Console.ReadLine());
                if(num_1<30)
                    Console.WriteLine(String.Format("You sure do look older than {0}", num_1));
                else
                    Console.WriteLine(String.Format("Are you sure ? You don't look like {0}", num_1));
              */
            //        var op=new Calculator();
            //        op.Cal();


            /*
             *  Sep 20 
             */

            //Guess g = new Guess();
            //g.play();
            //Console.ReadLine();


            /*
             *  sep 27
             */

            //var timeSpan = new TimeSpan(12,16,30);
            //Console.WriteLine(timeSpan);
            //Console.WriteLine(timeSpan.TotalDays);

            //Console.WriteLine("Enter a string with spaces");
            //var charac = Console.ReadLine();
            //var words = charac.Split(' ');
            //var finalString = "";
            //foreach (var word in words)
            //{
            //    var len = word.Length;
            //    finalString += Char.ToUpper(word[0]);
            //    finalString += word.Substring(1,len-1).ToLower();
            //    finalString += " ";
            //}

            //Console.WriteLine(finalString);

            //lists li = new lists();
            //li.DisplayNameAttribute();
            //li.DisplayNameAttributetwo();
            //li.reversal();
            //li.numbers();

            strings st = new strings();
            st.three();

            //GameLogic game = new GameLogic();

            //Console.WriteLine("Welcome to Rock, Paper, Scissors in C#! Enter 'q' at any time to quit.");
            //while (true)
            //{
            //    string compChoice = game.GetCompChoice();
            //    string userChoice = game.GetUserIn();
            //    if (userChoice == "q")
            //      {
            //        break;
            //    }
            //    game.ResOutput(compChoice, game.Play(userChoice, compChoice));
            //}

            Console.ReadKey();
        }
    }
}
