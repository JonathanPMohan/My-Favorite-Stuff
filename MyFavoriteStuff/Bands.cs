using System;

namespace MyFavoriteStuff
{
    class Bands
    {
        public string Name { get; }
        public string Genre { get; }
        public string Album { get; }

        public Bands(string name, string genre, string album)
        {
            Name = name;
            Genre = genre;
            Album = album;
        }
    }
}
