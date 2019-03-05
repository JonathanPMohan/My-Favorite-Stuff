using System;

namespace MyFavoriteStuff
{
    class NesGames
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }

        public NesGames(string name, string genre, int year)
        {
            Name = name;
            Genre = genre;
            Year = year;
        }
    }
}