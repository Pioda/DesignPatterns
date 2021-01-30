using FactoryMethod.Animals;
using FactoryMethod.Interfaces;

namespace FactoryMethod.Factories
{
    public class LionFactory : AnimalFactory
    {
        public override IAnimal Create()
        {
            return new Lion();
        }

        public override IAnimal CreateWithName(string name)
        {
            return new Lion(name);
        }
    }
}
