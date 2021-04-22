using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            var root = new CompositeElement("Picture");
            root.Add(new PrimitiveElement("Red line"));
            root.Add(new PrimitiveElement("Green box"));

            var comp = new CompositeElement("Circles");
            comp.Add(new PrimitiveElement("Black circle"));
            comp.Add(new PrimitiveElement("Red circle"));

            root.Add(comp);

            root.Display();
        }
    }
}
