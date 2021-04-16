using System;

namespace Prototype.ConcreteColor
{
    class Color : ColorPrototype
    {
        private readonly int _red;
        private readonly int _green;
        private readonly int _blue;

        public Color(int red, int green, int blue)
        {
            _red = red;
            _green = green;
            _blue = blue;
        }

        public override ColorPrototype Clone()
        {
            return MemberwiseClone() as ColorPrototype;
        }

        public void Show()
        {
            Console.WriteLine($"Color ({_red},{_green},{_blue})");
        }
    }
}
