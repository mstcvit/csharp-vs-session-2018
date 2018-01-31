using System;
using System.Collections.Generic;

namespace _9_lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfFruits = new List<string>();
            listOfFruits.Add("Apple");
            listOfFruits.Add("Orange");
            listOfFruits.Add("Mango");

            // Console.WriteLine(listOfFruits);
            for (var i = 0; i < listOfFruits.Count; ++i) {
                Console.WriteLine(listOfFruits[i]);
            }

            var listOfPeople = new List<string>() { "Sangeeth", "Pratik", "Ayush" };

            foreach (var name in listOfPeople)
            {
                Console.WriteLine(name);
            }
        }
    }
}
