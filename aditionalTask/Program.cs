using System;

namespace aditionalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write simple math operation (example: 5 * 32): ");
            dynamic result;
            while (true)
            {
                if (Calculator.TryParse(Console.ReadLine(), out result))
                    Console.WriteLine($" = {result}");
                else
                    Console.WriteLine("Wrong operation format!!!");
            }
        }
    }
}
