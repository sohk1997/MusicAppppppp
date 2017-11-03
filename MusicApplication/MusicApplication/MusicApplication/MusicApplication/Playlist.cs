using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApplication
{
    class Playlist
    {
        public string AlbumName { get; set; }
        public string AlbumURLImage { get; set; }
        public string ArtistName { get; set; }

        public Playlist(string a, string b, string c)
        {
            AlbumName = a;
            AlbumURLImage = b;
            ArtistName = c; // tạm đếm bài hát
        }


    }
}
