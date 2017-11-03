using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MusicApplication
{
    public class Song
    {
        public string SongName { get; set; }
        public string TextImage { get; set; }
        public string ArtistName { get; set; }

        public Song()
        {
        }
        public Song(string sName, string aName)
        {
            SongName = sName;
            ArtistName = aName;
        }
        
    }
}
