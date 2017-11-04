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
using System.Windows.Shapes;

namespace MusicApplication
{
    /// <summary>
    /// Interaction logic for PlaylistPopup.xaml
    /// </summary>
    public partial class PlaylistPopup : Window
    {
        List<ListViewItem> pls = new List<ListViewItem>();
        public PlaylistPopup()
        {
            InitializeComponent();
            ListViewItem item;
            for (int i = 0; i < 5; i++)
            {
                item = new ListViewItem();
                Playlist pl = new Playlist("Playlist");
                item.ContentTemplate = (DataTemplate)this.FindResource("ppPopup");
                item.Content = pl;
                pls.Add(item);
            }
            playlists.ItemsSource = pls;
        }
    }
}
