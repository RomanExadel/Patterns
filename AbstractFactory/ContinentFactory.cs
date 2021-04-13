using AbstractFactory.Carnivores;
using AbstractFactory.Herbivores;
using AbstractFactory.SuperPredators;

namespace AbstractFactory
{
    abstract class ContitentFactory
    {
        public abstract Herbivore CreateHerbivore();

        public abstract Carnivore CreateCarnivore();

        public abstract SuperPredator CreateSuperPredator();
    }
}
