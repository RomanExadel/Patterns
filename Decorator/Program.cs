using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Inside ASP.NET", "Worley");
            book.Display();
            
            var video = new Video("Spielberg", 92);
            video.Display();

            Console.WriteLine("------");

            var borrowvideo = new Borrowable(video);
            borrowvideo.BorrowItem("Customer #1");
            borrowvideo.BorrowItem("Customer #2");

            borrowvideo.Display();
        }
    }
}
