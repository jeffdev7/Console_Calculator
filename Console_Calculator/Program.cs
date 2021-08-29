using System;

namespace Console_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\nCalculator");
                Console.WriteLine("");
                Console.WriteLine("--------------------------");
                Console.WriteLine("1- Addition");
                Console.WriteLine("2- Subtraction");
                Console.WriteLine("3- Multiplication");
                Console.WriteLine("4- Division");
                Console.WriteLine("-------------------------");
                Console.WriteLine("0- Exit");
                Console.WriteLine("-------------------------");

                Console.Write("Option:");
                string option = Console.ReadLine();
                double a = 0;
                double b = 0;

                if (option == "0") Environment.Exit(0);

                Console.Write("A=");
                a = double.Parse(Console.ReadLine());
                Console.Write("B=");
                b = double.Parse(Console.ReadLine());

                if (option == "1")
                    Console.WriteLine(a + " + " + b + " = " + (a + b).ToString());
                else if (option == "2")
                    Console.WriteLine(a + " - " + b + " = " + (a - b).ToString());
                else if (option == "3")
                    Console.WriteLine(a + " x " + b + " = " + (a * b).ToString());
                else if (option == "4")
                    Console.WriteLine(a + " : " + b + " = " + (a / b).ToString("0.00"));
            }
        }
    }
}
