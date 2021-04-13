using AbstractFactory.Carnivores;
using AbstractFactory.Herbivores;
using AbstractFactory.SuperPredators;

namespace AbstractFactory.ConcreteFactory
{
    class BelarusFactory : ContitentFactory
    {
        public override Herbivore CreateHerbivore()
        {
            return new Bison();
        }

        public override Carnivore CreateCarnivore()
        {
            return new Snake();
        }

        public override SuperPredator CreateSuperPredator()
        {
            return new Eagle();
        }
    }
}
