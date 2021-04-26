using System;
using System.Collections.Generic;

namespace Decorator
{
    class Borrowable : Decorator
    {
        protected List<string> borrowers = new List<string>();

        public Borrowable(LibraryItem libraryItem) : base(libraryItem)
        {
        }

        public void BorrowItem(string name)
        {
            borrowers.Add(name);
            NumberOfCopies--;
        }

        public void ReturnItem(string name)
        {
            borrowers.Remove(name);
            NumberOfCopies++;
        }

        public override void Display()
        {
            base.Display();

            foreach (var borrower in borrowers)
            {
                Console.WriteLine(borrower);
            }
        }
    }
}
