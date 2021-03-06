﻿using FactoryMethod.Enums;
using FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;

namespace FactoryMethod.Animals
{
    internal class Monkey : IAnimal
    {
        private List<Food> PreferedFood;
        private readonly string Name;
        
        internal Monkey()
        {
            PreferedFood = new List<Food>() { Food.Vegetable };
            Name = "Monkey";
        }

        internal Monkey(string name)
        {
            PreferedFood = new List<Food>() { Food.Vegetable };
            Name = name;
        }

        public void Feed(Food food)
        {
            if (!PreferedFood.Contains(food))
                throw new InvalidOperationException($"Monkey does not want {food}!");
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
