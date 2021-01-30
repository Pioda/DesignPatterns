using FactoryMethod.Enums;
using System.Collections;
using System.Collections.Generic;

namespace FactoryMethod.Interfaces
{
    public interface IAnimal
    {
        IEnumerable<Food> GetFoodPreferences();
        void Feed(Food food);
        string GetName();
    }
}
