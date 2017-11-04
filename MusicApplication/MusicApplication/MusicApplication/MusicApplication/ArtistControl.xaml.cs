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
    /// Interaction logic for ArtistControl.xaml
    /// </summary>
    public partial class ArtistControl : UserControl
    {
        Frame parrent;
        List<ServiceReference.ArtistInfo> items = new List<ServiceReference.ArtistInfo>();
        public ArtistControl()
        {
            InitializeComponent();
            ServiceReference.ITransfer service = new ServiceReference.TransferClient();
            ServiceReference.DownloadRequest request = new ServiceReference.DownloadRequest();
            items = service.LoadAllArtist(request).ListOfArtist.ToList();
            foreach(ServiceReference.ArtistInfo artist in items)
            {
                using (System.IO.MemoryStream ms = new System.IO.MemoryStream(artist.RawData))
                {
                    artist.Image = new BitmapImage();
                    artist.Image.BeginInit();
                    artist.Image.CacheOption = BitmapCacheOption.OnLoad;
                    artist.Image.StreamSource = ms;
                    artist.Image.EndInit();
                }
            }
            lvArtists.ItemsSource = items;
<<<<<<< HEAD
        }

        public Frame Parrent { get => parrent; set => parrent = value; }

        private void StackPanel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            StackPanel panel = (StackPanel)sender;
            TextBlock block = (TextBlock)panel.Children[1];
            string singerName = block.Text;
            ServiceReference.ITransfer transfer = new ServiceReference.TransferClient();
            SongControl song = new SongControl();
            song.Items = transfer.FindSongOfSinger(singerName).ToList();
            parrent.Content = song.Content;
=======
>>>>>>> 7393b3e0aa25066a993813e9e81bdf7edbc76c4e
        }
    }
}
