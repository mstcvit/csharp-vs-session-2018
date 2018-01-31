using System;

namespace _6_varkeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Sangeeth";
            int age = 30;

            // becomes...

            var name1 = "Sangeeth";
            var age1 = 30;
            var marks = 60.5;

            Console.WriteLine($"{name1} {age1} {marks}");
        }
    }
}
