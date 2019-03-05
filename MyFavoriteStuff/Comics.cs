using System;

namespace MyFavoriteStuff
{
    class Comics
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Affilation { get; set; }

        public Comics(string name, string brand, string affilation)
        {
            Name = name;
            Brand = brand;
            Affilation = affilation;
        }
    }
}