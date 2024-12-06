using System.Linq;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1 = 0;
            float num2 = 0;
            bool valid = false;
            Console.Write("Enter the first number: ");
            while (!valid)
            {
                try { num1 = float.Parse(Console.ReadLine()); valid = true; }
                catch (FormatException e)
                {
                    Console.Write("Invalid input try again: ");
                }
            }

            valid = false;
            Console.Write("Enter the second number: ");
            while (!valid)
            {
                try { num2 = float.Parse(Console.ReadLine()); valid = true; }
                catch (FormatException e)
                {
                    Console.Write("Invalid input try again: ");
                }
            }

            Console.WriteLine("What would you like to do with these numbers?");
            Console.WriteLine("\ta - Addition");
            Console.WriteLine("\ts - Subtraction");
            Console.WriteLine("\tm - Multiplication");
            Console.WriteLine("\td - Division");
            string[] chars = { "a", "s", "m", "d" };
            string option = Console.ReadLine();
            while (!Array.Exists(chars, element => element == option)) 
            {
                Console.Write("Please enter a valid letter option and press enter: ");
                option = Console.ReadLine();
            }

            switch (option)
            {
                case "a":
                    Console.WriteLine("{0} + {1} = {2}", num1, num2, (num1 + num2));
                    break;
                case "s":
                    Console.WriteLine("{0} - {1} = {2}", num1, num2, (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine("{0} * {1} = {2}", num1, num2, (num1 * num2));
                    break;
                case "d":
                    valid = false;
                    while(num2 == 0 || !valid)
                    {
                        Console.WriteLine("Enter a non-zero divisor: ");
                        try { num2 = float.Parse(Console.ReadLine()); valid = true; valid = true; }
                        catch (Exception e)
                        {
                            Console.WriteLine("Invalid, try again: ");
                        }
                    }
                    Console.WriteLine("{0} / {1} = {2}", num1, num2, (num1 / num2));
                    break;
            }

        }
    }
}
