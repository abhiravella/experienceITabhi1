using System;
using Convert = System.Convert;

namespace ConsoleApp1
{
    class Calculator
    {
        public void Cal()
        {
            Console.WriteLine("Enter the operataion to be performed and two numbers or END, to cancel the operation");
            var operator_val = Console.ReadLine();
            float val;
            while (! (operator_val == "end"))
            {
                switch (operator_val)
                {
                    case "*":
                        val=Mul();
                        Console.WriteLine(val);
                        operator_val = Console.ReadLine();
                        break;
                    case "+":
                        val = Add();
                        Console.WriteLine(val);
                        operator_val = Console.ReadLine();
                        break;
                    case "-":
                        val = Sub();
                        Console.WriteLine(val);
                        operator_val = Console.ReadLine();
                        break;
                    case "/":
                        val = Div();
                        Console.WriteLine(val);
                        operator_val = Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Enter valid operator");
                        operator_val = Console.ReadLine();
                        break;
                }                
            }

            return ;
        }
        private float Add()
        {
            var num1 = Convert.ToSingle(Console.ReadLine());
            var num2 = Convert.ToSingle(Console.ReadLine());
            return (num1 + num2);
        }
        private float Sub()
        {
            var num1 = Convert.ToSingle(Console.ReadLine());
            var num2 = Convert.ToSingle(Console.ReadLine());
            return (num1 - num2);
        }
        private float Div()
        {
            var num1 = Convert.ToSingle(Console.ReadLine());
            var num2 = Convert.ToSingle(Console.ReadLine());
            return (num1 / num2);
        }
        private float Mul()
        {
            var num1 = Convert.ToSingle(Console.ReadLine());
            var num2 = Convert.ToSingle(Console.ReadLine());
            return (num1 * num2);
        }
    }
}
