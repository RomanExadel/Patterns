using FactoryMethod.ConcretePage;

namespace FactoryMethod.ConcreteCreator
{
    class Resume : Document
    {
        public override void CreatePages()
        {
            Pages.Add(new SkiilsPage());
            Pages.Add(new EducationPage());
            Pages.Add(new ExperiencePage());
        }
    }
}
