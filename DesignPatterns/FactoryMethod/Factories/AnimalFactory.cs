using FactoryMethod.Enums;
using FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Factories
{
    public abstract class AnimalFactory
    {
        public abstract IAnimal Create();
    }
}
