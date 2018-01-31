using System;

namespace _2_variables
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName = "John Cena";

            Console.WriteLine(myName);
            Console.WriteLine("His name is " + myName);
            Console.WriteLine($"His name is {myName}");

            int age = 30;
            Console.WriteLine($"His name is {myName} and he is {age} years old");
        }
    }
}
