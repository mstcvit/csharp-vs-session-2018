using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExample
{
    class Car
    {
        public string Model { get; set; }
        public string Brand { get; set; }
        public double TopSpeed { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var listOfCars = new List<Car>
            {
                new Car() { Brand="Lambo", Model="Huracan", TopSpeed=201 },
                new Car() { Brand="Buggatti", Model="Veyron", TopSpeed=267.9 },
                new Car() { Brand="Henessey", Model="Venom GT", TopSpeed=270.9 },
                new Car() { Brand="McLaren", Model="F1", TopSpeed=241 },
                new Car() { Brand="Pagani", Model="Huayra", TopSpeed=230 }
            };

            var greaterThan250 = from car in listOfCars
                                 where car.TopSpeed > 250
                                 select car.Model;

            foreach(var name in greaterThan250)
            {
                Console.WriteLine(name);
            }
        }
    }
}
