using System;

namespace _10_class_objects
{
    class Car {
        public string brand;
        public string model;
        public double topSpeed;

        public Car(string b, string m, double t) {
            brand = b;
            model = m;
            topSpeed = t;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car("Lambo", "Huracan", 201);

            Console.WriteLine($"Car name is ${myCar.brand} ${myCar.model} and it has a top speed of ${myCar.topSpeed}");
        }
    }
}
