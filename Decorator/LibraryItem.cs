namespace Decorator
{
    abstract class LibraryItem
    {
        public int NumberOfCopies { get; set; }

        public abstract void Display();
    }
}
