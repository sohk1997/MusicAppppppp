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

        public Home()
        {
            InitializeComponent();
            ListViewItem item;
            ServiceReference.ITransfer service = new ServiceReference.TransferClient();
            List<ServiceReference.SongInfo> songList = service.Get15Song().ToList();
            for (int i = 0; i < songList.Count; i++)
            {
                item = new ListViewItem();
                item.ContentTemplate = (DataTemplate)this.FindResource("songHome");
                item.Content = songList[i];
                songs.Add(item);
            }
            lvHomeSongs.ItemsSource = songs;

            List<ServiceReference.AlbumInfo> itemsPlaylist = new List<ServiceReference.AlbumInfo>();

            itemsPlaylist = service.Get10Album().ToList();
            lvPlaylists.ItemsSource = itemsPlaylist;
        }
    }
}
