using System.Collections.Generic;

namespace Flyweight
{
    class CharacterFactory
    {
        private readonly Dictionary<char, Character> _characters =
            new();

        public Character GetCharacter(char key)
        {
            Character character;

            if (_characters.ContainsKey(key))
            {
                character = _characters[key];
            }
            else
            {
                character = key switch
                {
                    'A' => new CharacterA(),
                    'B' => new CharacterB(),
                    _ => null
                };
                _characters.Add(key, character);
            }

            return character;
        }
    }
}
