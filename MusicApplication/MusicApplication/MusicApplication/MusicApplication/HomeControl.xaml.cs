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
        List<ListViewItem> songs = new List<ListViewItem>();
        List<ListViewItem> playlists = new List<ListViewItem>();
        List<Playlist> itemsPlaylist = new List<Playlist>();
        public Home()
        {
            InitializeComponent();
            ListViewItem item;
            
            
            for (int i = 0; i < 10; i++)
            {
                item = new ListViewItem();
                item.ContentTemplate = (DataTemplate)this.FindResource("songHome");
                item.Content = new Song("Ahihi1", "Ahuhu");
                songs.Add(item);
            }
            lvHomeSongs.ItemsSource = songs;


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
