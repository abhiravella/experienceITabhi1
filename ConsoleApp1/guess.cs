using System;


namespace ConsoleApp1
{
    class Guess
    {
        public void play()
        {
            var gen = new Random();
            var value = gen.Next(1, 10);
            var guess=0;
            var counter = 1;
            Console.WriteLine("Enter your guess");
            while (counter <= 4)
            {
                guess = Convert.ToInt16(Console.ReadLine());
                if (guess == value)
                {
                    Console.WriteLine("You won. The secret number is {0}",value);
                    return;                
                }
                else
                {
                    Console.WriteLine("Hahahaha.... You're wrong");
                    Console.WriteLine("You've got {0} more guesses",(4-counter));
                    counter++;
                }
            }
            Console.WriteLine("The number is {0}",value);
            return;
        }
    }
}