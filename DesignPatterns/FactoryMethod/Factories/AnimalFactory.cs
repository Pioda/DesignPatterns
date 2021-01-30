using FactoryMethod.Interfaces;

namespace FactoryMethod.Factories
{
    public abstract class AnimalFactory
    {
        public abstract IAnimal Create();
        public abstract IAnimal CreateWithName(string name);
    }
}
