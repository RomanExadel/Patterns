using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Video : LibraryItem
    {
        private readonly string _name;
        private readonly int _playTime;

        public Video(string name, int playTime)
        {
            _name = name;
            _playTime = playTime;
        }

        public override void Display()
        {
            Console.WriteLine("Video");
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine($"PlayTime: {_playTime}");
        }
    }
}
