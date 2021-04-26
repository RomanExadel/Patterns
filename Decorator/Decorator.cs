using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    abstract class Decorator : LibraryItem
    {
        protected LibraryItem _libraryItem;

        public Decorator(LibraryItem libraryItem)
        {
            _libraryItem = libraryItem;
        }

        public override void Display()
        {
            _libraryItem.Display();
        }
    }
}
