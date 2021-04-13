using AbstractFactory.ConcreteFactory;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var belarus = new BelarusFactory();
            var world = new AnimalWorld(belarus);
            world.RunFoodChain();
        }
    }
}
