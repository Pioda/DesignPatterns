using FactoryMethod.Animals;
using FactoryMethod.Interfaces;

namespace FactoryMethod.Factories
{
    public class BearFactory : AnimalFactory
    {
        public override IAnimal Create()
        {
            return new Bear();
        }

        public override IAnimal CreateWithName(string name)
        {
            return new Bear(name);
        }
    }
}
