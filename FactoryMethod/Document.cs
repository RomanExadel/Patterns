using System.Collections.Generic;

namespace FactoryMethod
{
    abstract class Document
    {
        private List<Page> _pages = new();

        public Document()
        {
            CreatePages();
        }

        public List<Page> Pages => _pages;

        public abstract void CreatePages();
    }
}
