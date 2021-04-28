using System;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            var chars = "AB".ToCharArray();

            var characterFactory = new CharacterFactory();

            var pointSize = 10;

            foreach (var @char in chars)
            {
                var character = characterFactory.GetCharacter(@char);
                character.Display(pointSize);
                pointSize++;
            }
        }
    }
}
