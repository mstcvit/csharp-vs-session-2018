using System;

namespace _8_branching
{
    class Program
    {
        static void Main(string[] args)
        {
            // I want to know a number is odd or even
            var number = 3;

            if (number % 2 == 0) {
                Console.WriteLine("Even");
            } else {
                Console.WriteLine("Odd");
            }

            // I want to know my grade

            var marks = 76;

            if (marks >= 90) {
                Console.WriteLine("S");
            } else if (marks >= 80) {
                Console.WriteLine("A");
            } else if (marks >= 70) {
                Console.Write("B");
            } else {
                Console.WriteLine("Better luck next time");
            }
        }
    }
}
