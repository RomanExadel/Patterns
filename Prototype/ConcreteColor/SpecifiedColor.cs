using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.ConcreteColor
{
    class SpecifiedColor : ColorPrototype
    {
        private readonly int _light;

        public SpecifiedColor(int light)
        {
            _light = light;
        }

        public override ColorPrototype Clone()
        {
            return MemberwiseClone() as ColorPrototype;;
        }

        public override void Show()
        {
            Console.WriteLine($"SpecifiedColor with light {_light}");
        }
    }
}
