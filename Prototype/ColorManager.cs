using System.Collections.Generic;

namespace Prototype
{
    class ColorManager
    {
        private readonly Dictionary<string, ColorPrototype> _colors =new();
        
        public ColorPrototype this[string key]
        {
            get => _colors[key];
            set => _colors.Add(key, value);
        }
    }
}
