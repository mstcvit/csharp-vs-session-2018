using System;

namespace _5_operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(2 + 3);  // addition
            Console.WriteLine(5 - 3);  // subtraction
            Console.WriteLine(10 * 3); // multiplication
            Console.WriteLine(10 / 2); // division
            Console.WriteLine(10 % 3); // modulo, i.e, remainder of division

            Console.WriteLine(2 + 2 - 1);
            Console.WriteLine(3 + 5 * 2); // Note: Precedence of operators matters! Mul before Add.
            Console.WriteLine((3 + 5) * 2);

            Console.WriteLine(10 / 3);   // but isn't that supposed to be 3.3333... ?

            // Type matters in C#. Integer division gives integer result.
            Console.WriteLine(89 / 9);   // Truncates the decimal part
            Console.WriteLine(89 / 9.0); // Force float result
        }
    }
}
