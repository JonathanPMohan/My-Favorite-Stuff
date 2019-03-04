using System;

namespace MyFavoriteStuff
{
    class Comics
    {
        public string Name { get; }
        public string Brand { get; }
        public string Affilation { get; }

        public Comics(string name, string brand, string affilation)
        {
            Name = name;
            Brand = brand;
            Affilation = affilation;
        }
    }
}