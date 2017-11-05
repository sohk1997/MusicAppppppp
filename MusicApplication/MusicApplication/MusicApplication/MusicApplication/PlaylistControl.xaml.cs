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
            List<ServiceReference.AlbumInfo> itemsPlaylist = new List<ServiceReference.AlbumInfo>();
            ServiceReference.ITransfer service = new ServiceReference.TransferClient();
            itemsPlaylist = service.Get10Album().ToList();
            lvPlaylists.ItemsSource = itemsPlaylist;
        }

        private void lvPlaylists_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            AlbumInfo album = new AlbumInfo();
            this.Content = album.Content;
        }
    }
}
