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
    /// Interaction logic for PlaylistControl.xaml
    /// </summary>
    public partial class PlaylistControl : UserControl
    {
        List<Playlist> items = new List<Playlist>();
        public PlaylistControl()
        {
            InitializeComponent();

            items.Add(new Playlist("Album", @"Image/Singer/s1.jpg", "Noo Phước Thịnh"));
            items.Add(new Playlist("Album", @"Image/Singer/s1.jpg", "Noo Phước Thịnh"));
            items.Add(new Playlist("Album", @"Image/Singer/s1.jpg", "Noo Phước Thịnh"));
            items.Add(new Playlist("Album", @"Image/Singer/s1.jpg", "Noo Phước Thịnh"));
            items.Add(new Playlist("Album", @"Image/Singer/s1.jpg", "Noo Phước Thịnh"));
            items.Add(new Playlist("Album", @"Image/Singer/s1.jpg", "Noo Phước Thịnh"));
            items.Add(new Playlist("Album", @"Image/Singer/s1.jpg", "Noo Phước Thịnh"));
            items.Add(new Playlist("Album", @"Image/Singer/s1.jpg", "Noo Phước Thịnh"));
            items.Add(new Playlist("Album", @"Image/Singer/s1.jpg", "Noo Phước Thịnh"));
            items.Add(new Playlist("Album", @"Image/Singer/s1.jpg", "Noo Phước Thịnh"));
            items.Add(new Playlist("Album", @"Image/Singer/s1.jpg", "Noo Phước Thịnh"));
            items.Add(new Playlist("Album", @"Image/Singer/s1.jpg", "Noo Phước Thịnh"));

            items.Add(new Playlist("Album", @"Image/Singer/s1.jpg", "Noo Phước Thịnh"));
            items.Add(new Playlist("Album", @"Image/Singer/s1.jpg", "Noo Phước Thịnh"));
            items.Add(new Playlist("Album", @"Image/Singer/s1.jpg", "Noo Phước Thịnh"));
            items.Add(new Playlist("Album", @"Image/Singer/s1.jpg", "Noo Phước Thịnh"));
            items.Add(new Playlist("Album", @"Image/Singer/s1.jpg", "Noo Phước Thịnh"));

            items.Add(new Playlist("Album", @"Image/Singer/s1.jpg", "Noo Phước Thịnh"));
            items.Add(new Playlist("Album", @"Image/Singer/s1.jpg", "Noo Phước Thịnh"));
            items.Add(new Playlist("Album", @"Image/Singer/s1.jpg", "Noo Phước Thịnh"));
            items.Add(new Playlist("Album", @"Image/Singer/s1.jpg", "Noo Phước Thịnh"));
            items.Add(new Playlist("Album", @"Image/Singer/s1.jpg", "Noo Phước Thịnh"));
            lvPlaylists.ItemsSource = items;
        }

        private void lvPlaylists_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            AlbumInfo album = new AlbumInfo();
            this.Content = album.Content;
        }
    }
}
