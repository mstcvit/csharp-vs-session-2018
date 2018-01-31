using System;

namespace _3_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a message and I'll shout it out for you: ");
            string message = Console.ReadLine();

            Console.WriteLine(message.ToUpper());
        }
    }
}
