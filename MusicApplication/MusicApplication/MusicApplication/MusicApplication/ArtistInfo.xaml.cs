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
    /// Interaction logic for ArtistInfo.xaml
    /// </summary>
    public partial class ArtistInfo : UserControl
    {
        List<ListViewItem> lvItems = new List<ListViewItem>();
        ListViewItem item;
        public ArtistInfo()
        {
            InitializeComponent();

            Song s;
            Artist artist = new Artist();
            for (int i = 0; i < 15; i++)
            {
                item = new ListViewItem();
                s = new Song("Ahihi", "Ahohohohohoh");
                item.ContentTemplate = (DataTemplate)this.FindResource("listViewSong");
                item.Content = s;
                lvItems.Add(item);

                lvAtistSong.ItemsSource = lvItems;
            }
            List<Playlist> playlists = new List<Playlist>();
            for (int i = 0; i < 15; i++)
            {
                playlists.Add(new Playlist("Ahihi", "/Image/zig.jpg", "Ahohohohohoh"));
            }
            lvArtistAlbum.ItemsSource = playlists;
            artist.Infomation = "sadasdasdassadasdasdassadasdasdassadasdasdassadasdasdassadasdasdassadasdasdassadasdasdassadasdasdassadasdasdas" +
                "sadasdasdassadasdasdassadasdasdassadasdasdassadasdasdassadasdasdassadasdasdassadasdasdassadasdasdassadasdasdassadasdasdassadasdasdassadasdasdas" +
                "sadasdasdassadasdasdassadasdasdassadasdasdassadasdasdassadasdasdassadasdasdassadasdasdas";
            txtInformation.Text = artist.Infomation;


        }
    }
    }
