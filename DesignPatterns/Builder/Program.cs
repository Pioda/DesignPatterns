using Builder.CompositeBuilder;
using Builder.FluentBuilder;
using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {

            Coffee coffee = Coffee
                .Create()
                .BlackCoffee()
                .WithMilk()
                .WithRum();

            House house = House
                .Create()
                .WithArea(250.75)
                .WithLevels(3)
                .WithGarden()
                    .WithGrillSpace()
                    .WithGardenHouse()
                    .WithGardenArea(120)
                .WithGarage()
                    .WithGarageCarSpace(3)
                    .WithGarageArea(30);


            Console.WriteLine(coffee.ToString());
            Console.ReadLine();
        }
    }
}
