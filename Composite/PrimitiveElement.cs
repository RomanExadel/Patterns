using System;

namespace Composite
{
    class PrimitiveElement : DrawingElement
    {
        public PrimitiveElement(string name) : base(name)
        {
        }

        public override void Add(DrawingElement drawingElement)
        {
            Console.WriteLine("Cannot add to a PrimitiveElement");
        }

        public override void Remove(DrawingElement drawingElement)
        {
            Console.WriteLine("Cannot remove from a PrimitiveElement");
        }

        public override void Display()
        {
            Console.WriteLine(_name);
        }
    }
}
