using FactoryMethod.Animals;
using FactoryMethod.Interfaces;

namespace FactoryMethod.Factories
{
    public class MonkeyFactory : AnimalFactory
    {
        public override IAnimal Create()
        {
            return new Monkey();
        }

        public override IAnimal CreateWithName(string name)
        {
            return new Monkey(name);
        }
    }
}
