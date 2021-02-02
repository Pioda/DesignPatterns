using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {

            Coffee coffee = Coffee.Create().BlackCoffee().WithMilk().WithRum();
            Console.WriteLine(coffee.ToString());
            Console.ReadLine();
        }
    }
}
