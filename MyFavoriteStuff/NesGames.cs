using System;

namespace MyFavoriteStuff
{
    class NesGames
    {
        public string Name { get; }
        public string Genre { get; }
        public int Year { get; }

        public NesGames(string name, string genre, int year)
        {
            Name = name;
            Genre = genre;
            Year = year;
        }
    }
}