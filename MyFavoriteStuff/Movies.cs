using System;

namespace MyFavoriteStuff
{
    class Movies
    {
        public string Name { get; }
        public string Genre { get; }
        public int Year { get; }

        public Movies(string name, string genre, int year)
        {
            Name = name;
            Genre = genre;
            Year = year;
        }
    }
}