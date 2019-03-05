using System;

namespace MyFavoriteStuff
{
    class Movies
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }

        public Movies(string name, string genre, int year)
        {
            Name = name;
            Genre = genre;
            Year = year;
        }
    }
}