﻿using FactoryMethod.Enums;
using FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;

namespace FactoryMethod.Animals
{
    internal class Lion : IAnimal
    {
        private List<Food> PreferedFood;
        private readonly string Name;

        internal Lion()
        {
            PreferedFood = new List<Food>() { Food.Meat };
            Name = "Lion";
        }

        internal Lion(string name)
        {
            PreferedFood = new List<Food>() { Food.Meat };
            Name = name;
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
