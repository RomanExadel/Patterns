using AbstractFactory.Carnivores;
using AbstractFactory.Herbivores;
using AbstractFactory.SuperPredators;

namespace AbstractFactory
{
    class AnimalWorld
    {
        private readonly Herbivore _herbivore;
        private readonly Carnivore _carnivore;
        private readonly SuperPredator _superPredator;

        public AnimalWorld(ContitentFactory factory)
        {
            _herbivore = factory.CreateHerbivore();
            _carnivore = factory.CreateCarnivore();
            _superPredator = factory.CreateSuperPredator();
        }

        public void RunFoodChain()
        {
           _carnivore.Eat(_herbivore);
           _superPredator.Eat(_carnivore);
        }
    }
}
