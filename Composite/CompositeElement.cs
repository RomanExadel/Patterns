using System;
using System.Collections.Generic;

namespace Composite
{
    class CompositeElement : DrawingElement
    {
        private readonly List<DrawingElement> _drawingElements = new List<DrawingElement>();

        public CompositeElement(string name) : base(name)
        {
        }

        public override void Add(DrawingElement drawingElement)
        {
            _drawingElements.Add(drawingElement);
        }

        public override void Remove(DrawingElement drawingElement)
        {
            _drawingElements.Remove(drawingElement);
        }

        public override void Display()
        {
            Console.WriteLine("-----------------");

            foreach (var VARIABLE in _drawingElements)
            {
                VARIABLE.Display();
            }
        }
    }
}
