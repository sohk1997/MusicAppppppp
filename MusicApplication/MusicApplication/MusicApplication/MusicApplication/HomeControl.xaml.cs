using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MusicApplication
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : UserControl
    {
        List<Song> items = new List<Song>();
        List<Playlist> itemsPlaylist = new List<Playlist>();
        public Home()
        {
            InitializeComponent();
            items.Add(new Song("Ahihi", "Ahuhu"));
            items.Add(new Song("Ahihi", "Ahuhu"));
            items.Add(new Song("Ahihi", "Ahuhu"));
            items.Add(new Song("Ahihi", "Ahuhu"));
            items.Add(new Song("Ahihi", "Ahuhu"));
            items.Add(new Song("Ahihi", "Ahuhu"));
            items.Add(new Song("Ahihi", "Ahuhu"));
            items.Add(new Song("Ahihi", "Ahuhu"));
            lvHomeSongs.ItemsSource = items;
            
            itemsPlaylist.Add(new Playlist("Album1", "/Image/Singer/s1.jpg", "Ca sĩ 1"));
            itemsPlaylist.Add(new Playlist("Album1", "/Image/Singer/s1.jpg", "Ca sĩ 1"));
            itemsPlaylist.Add(new Playlist("Album1", "/Image/Singer/s1.jpg", "Ca sĩ 1"));
            itemsPlaylist.Add(new Playlist("Album1", "/Image/Singer/s1.jpg", "Ca sĩ 1"));
            itemsPlaylist.Add(new Playlist("Album1", "/Image/Singer/s1.jpg", "Ca sĩ 1"));
            itemsPlaylist.Add(new Playlist("Album1", "/Image/Singer/s1.jpg", "Ca sĩ 1"));
            itemsPlaylist.Add(new Playlist("Album1", "/Image/Singer/s1.jpg", "Ca sĩ 1"));
            itemsPlaylist.Add(new Playlist("Album1", "/Image/Singer/s1.jpg", "Ca sĩ 1"));
            itemsPlaylist.Add(new Playlist("Album1", "/Image/Singer/s1.jpg", "Ca sĩ 1"));
            itemsPlaylist.Add(new Playlist("Album1", "/Image/Singer/s1.jpg", "Ca sĩ 1"));
            itemsPlaylist.Add(new Playlist("Album1", "/Image/Singer/s1.jpg", "Ca sĩ 1"));
            lvPlaylists.ItemsSource = itemsPlaylist;


        }
    }
}
