using FactoryMethod.Animals;
using FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Factories
{
    public class MonkeyFactory : AnimalFactory
    {
        public override IAnimal Create()
        {
            return new Monkey();
        }
    }
}
