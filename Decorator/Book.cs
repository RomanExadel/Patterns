using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Book : LibraryItem
    {
        private readonly string _name;
        private readonly string _author;

        public Book(string name, string author)
        {
            _name = name;
            _author = author;
        }

        public override void Display()
        {
            Console.WriteLine("Book");
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine($"Author: {_author}");
        }
    }
}
