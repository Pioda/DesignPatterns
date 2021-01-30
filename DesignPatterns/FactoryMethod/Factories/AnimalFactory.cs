using FactoryMethod.Enums;
using FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Factories
{
    internal abstract class AnimalFactory
    {
        internal abstract IAnimal Create();
    }
}
