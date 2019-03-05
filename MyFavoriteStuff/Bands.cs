using System;

namespace MyFavoriteStuff
{
    class Bands
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public string Album { get; set; }

        public Bands(string name, string genre, string album)
        {
            Name = name;
            Genre = genre;
            Album = album;
        }
    }
}
