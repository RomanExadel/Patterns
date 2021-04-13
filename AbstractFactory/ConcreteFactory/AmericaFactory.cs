using AbstractFactory.Carnivores;
using AbstractFactory.Herbivores;
using AbstractFactory.SuperPredators;

namespace AbstractFactory.ConcreteFactory
{
    class AmericaFactory : ContitentFactory
    {
        public override Herbivore CreateHerbivore()
        {
            return new Wildebeest();
        }

        public override Carnivore CreateCarnivore()
        {
            return new Wolf();
        }

        public override SuperPredator CreateSuperPredator()
        {
            return new Eagle();
        }
    }
}
