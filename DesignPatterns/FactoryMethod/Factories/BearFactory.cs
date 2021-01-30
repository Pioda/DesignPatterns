using FactoryMethod.Animals;
using FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Factories
{
    internal class BearFactory : AnimalFactory
    {
        internal override IAnimal Create()
        {
            return new Bear();
        }
    }
}
