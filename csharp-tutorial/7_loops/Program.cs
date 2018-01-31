using System;

namespace _7_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // I want to print "Gucci gang" like 50 times
            for (var i = 1; i <= 50; ++i) {
                Console.WriteLine("Gucci Gang");
            }

            // I want to keep printing Gucci gang until I want it to stop

            while (true) {
                Console.WriteLine("Gucci Gang");
                Console.Write("Wanna stop? ");
                var answer = Console.ReadLine();

                if (answer == "yes") {
                    break;
                }
            }
        }
    }
}
