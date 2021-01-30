using FactoryMethod.Enums;
using FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Animals
{
    internal class Bear : IAnimal
    {        
        private List<Food> PreferedFood;
        private readonly string Name;

        internal Bear()
        {
            PreferedFood = new List<Food>() { Food.Meat, Food.Vegetable };
            Name = "Bear";
        }

        public void Feed(Food food)
        {
            if (!PreferedFood.Contains(food))
                throw new InvalidOperationException($"Bear does not want {food}!");
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
