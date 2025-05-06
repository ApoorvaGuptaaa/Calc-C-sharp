using System;
using System.Linq;
using System.Numerics;
using System.Xml.Serialization;

namespace Calc
{
    class Calculator
    {
        static void Add()
        {
            Console.WriteLine("Enter first number: ");
            string a = Console.ReadLine();
            int x  = Int32.Parse(a);
            Console.WriteLine("Enter second number: ");
            string b = Console.ReadLine();
            int y = Int32.Parse(b);

            int c = x + y;
            Console.WriteLine("Result: " + c);
        }
        static void Sub()
        {
            Console.WriteLine("Enter first number: ");
            string a = Console.ReadLine();
            int x = Int32.Parse(a);
            Console.WriteLine("Enter second number: ");
            string b = Console.ReadLine();
            int y = Int32.Parse(b);

            int c = x - y;
            Console.WriteLine("Result: " + c);
        }
        static void Mult()
        {
            Console.WriteLine("Enter first number: ");
            string a = Console.ReadLine();
            int x = Int32.Parse(a);
            Console.WriteLine("Enter second number: ");
            string b = Console.ReadLine();
            int y = Int32.Parse(b);

            int c = x * y;
            Console.WriteLine("Result: " + c);
        }
        static void Div()
        {
            try
            {
                Console.WriteLine("Enter first number: ");
                string a = Console.ReadLine();
                int x = Int32.Parse(a);
                Console.WriteLine("Enter second number: ");
                string b = Console.ReadLine();
                int y = Int32.Parse(b);

                int c = x / y;
                Console.WriteLine("Result: " + c);
            }

            catch (DivideByZeroException) 
            {
                Console.WriteLine("Infinity \n Reason: Tried division by Zero (0).");            
            }

        }
        static void Perc()
        {
            Console.WriteLine("Enter percentage: ");
            string a = Console.ReadLine();
            int x = Int32.Parse(a);
            Console.WriteLine("Enter number: ");
            string b = Console.ReadLine();
            int y = Int32.Parse(b);

            int c = ( x * y ) / 100;
            Console.WriteLine("Result: " + c);
        }
        static void Exit()
        {
            Console.WriteLine("Thank You for using the Calculator! ");
        }
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            
            Console.WriteLine("Welcome!! \n Calculator can perform the following:");

            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Percentage");
            Console.WriteLine("6. Exit");

            Console.WriteLine("Choose an operation: ");
            string choice = Console.ReadLine();
            int ch = Int32.Parse(choice);

            switch (ch)
            {
                case 1:
                    Console.WriteLine("You chose Addition.");
                    Add();
                    break;
                case 2:
                    Console.WriteLine("You chose Subtraction.");
                    Sub();
                    break;
                case 3:
                    Console.WriteLine("You chose Multiplication.");
                    Mult();
                    break;
                case 4:
                    Console.WriteLine("You chose Division.");
                    Div();
                    break;
                case 5:
                    Console.WriteLine("You chose Percentage.");
                    Perc();
                    break;
                case 6:
                    Exit();
                    break;
            }

        }
    }
}