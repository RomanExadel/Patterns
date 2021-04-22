namespace Composite
{
    abstract class DrawingElement
    {
        protected string _name;

        public DrawingElement(string name)
        {
            _name = name;
        }

        public abstract void Add(DrawingElement drawingElement);

        public abstract void Remove(DrawingElement drawingElement);

        public abstract void Display();
    }
}
