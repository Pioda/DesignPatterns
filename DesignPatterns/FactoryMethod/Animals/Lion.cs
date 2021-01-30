using FactoryMethod.Enums;
using FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Animals
{
    internal class Lion : IAnimal
    {
        private List<Food> PreferedFood;
        private readonly string Name;

        public Lion()
        {
            PreferedFood = new List<Food>() { Food.Meat };
            Name = "Lion";
        }

        public void Feed(Food food)
        {
            if (!PreferedFood.Contains(food))
                throw new InvalidOperationException($"Lion does not want {food}!");
        }

        public IEnumerable<Food> GetFoodPreferences()
        {
            return PreferedFood;
        }

        public string GetName()
        {
            return Name;
        }
    }
}
