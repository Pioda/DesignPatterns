using FactoryMethod.Enums;
using FactoryMethod.Factories;
using FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FactoryMethod
{
    class Program
    {
        private static List<string> Commands = new List<string>() { "create", "feed", "list", "pref" };
        private static List<IAnimal> Animals = new List<IAnimal>();
        static void Main(string[] args)
        {
            string input;
            Console.WriteLine("Welcome to the ZooFactory!");
            Console.WriteLine("\t Please refer to the 'Help' on how to proceed.");
            DisplayHelp();
            Console.WriteLine();

            while ((input = Console.ReadLine()) != "exit")
            {
                var split = input.Split(" ");
                if (split.Length < 1 && split.Length != 3)
                {
                    DisplayHelp();
                    continue;
                }

                var cmd = split[0].ToLower();

                if (!Commands.Contains(cmd))
                {
                    DisplayHelp();
                    continue;
                }

                switch (cmd)
                {
                    case "create":
                        var animal = split[1].ToLower();
                        CreateAnimal(animal);
                        break;
                    case "feed":
                        var food = (Food)Enum.Parse(typeof(Food), split[2]);
                        animal = split[1].ToLower();
                        FeedAnimal(animal, food);
                        break;
                    case "list":
                        DisplayAnimals();
                        break;
                    case "pref":
                        ShowPreferences();
                        break;
                    default:
                        DisplayHelp();
                        break;
                }
                Console.WriteLine();
            }
        }

        private static void DisplayAnimals()
        {
            foreach (var animal in Animals)
                Console.WriteLine($"{animal.GetName()}");
        }

        private static void ShowPreferences()
        {
            foreach (var animal in Animals)
                Console.WriteLine($"{animal.GetName()} likes {string.Join(',', animal.GetFoodPreferences())}");
        }

        private static void CreateAnimal(string animal)
        {
            AnimalFactory factory;
            switch (animal)
            {
                case "monkey":
                    factory = new MonkeyFactory();
                    break;
                case "lion":
                    factory = new LionFactory();
                    break;
                case "bear":
                    factory = new BearFactory();
                    break;
                default:
                    DisplayHelp();
                    return;
            }
            Animals.Add(factory.Create());
            Console.WriteLine($"{animal} created!");
        }

        private static void FeedAnimal(string animal, Food food)
        {
            foreach (var entry in Animals.Where(x => x.GetName().Equals(animal, StringComparison.InvariantCultureIgnoreCase)))
            {
                try
                {
                    entry.Feed(food);
                    Console.WriteLine($"Fed {animal} some {food}!");
                } 
                catch(InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private static void DisplayHelp()
        {
            Console.WriteLine();
            Console.WriteLine("======= Help ========");
            Console.WriteLine("Type 'Create animal' to create an animal. Possible animals are:");
            Console.WriteLine("Monkey, Lion, Bear");
            Console.WriteLine("=======      ========");
            Console.WriteLine("Type 'Feed animal food' to feed an animal. Feeder options are:");
            Console.WriteLine("Vegetable, Meat");
            Console.WriteLine("=======      ========");
            Console.WriteLine("Type 'list' to see all animals");
            Console.WriteLine("=======      ========");
            Console.WriteLine("Type 'pref' to see all animals food preferences");
            Console.WriteLine("=======      ========");
            Console.WriteLine("Type 'exit' to end the application");
            Console.WriteLine("=======End Help========");
            Console.WriteLine();
        }
    }
}
