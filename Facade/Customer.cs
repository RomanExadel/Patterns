using System;

namespace Facade
{
    class Customer
    {
        private string _name;

        public Customer(string name)
        {
            Name = name;
        }

        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(value));
                }

                _name = value;
            }
        }

        public override string ToString()
        {
            return $"Name: {_name}";
        }
    }
}
