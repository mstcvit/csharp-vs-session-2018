using System;

namespace _4_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1729;
            double b = 1.3333333;
            byte c = 128;

            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
            Console.WriteLine($"c = {c}");

            // Let's try calculating the area of a circle
            double radius = 10;
            double area = Math.PI * radius * radius;

            Console.WriteLine($"Area of the circle is {area}");
        }
    }
}
