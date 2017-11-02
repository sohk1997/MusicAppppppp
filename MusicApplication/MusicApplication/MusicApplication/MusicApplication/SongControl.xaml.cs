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
    /// Interaction logic for SongControl.xaml
    /// </summary>
    public partial class SongControl : UserControl
    {
        List<ServiceReference.SongInfo> items;
        MainWindow parrent;
        public SongControl()
        {
            InitializeComponent();
            ServiceReference.ITransfer service = new ServiceReference.TransferClient();
            items = service.GetAllSong().ToList();
            lvSongs.ItemsSource = items;
        }

        public MainWindow Parrent { get => parrent; set => parrent = value; }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var fileDialog = new System.Windows.Forms.OpenFileDialog();
            var result = fileDialog.ShowDialog();
            //System.Windows.Controls.Image image = (System.Windows.Controls.Image)sender;
            //DownloadSong downloadControl = new DownloadSong()
            //{

            //    SongID = "S" + image.Tag.ToString(),
            //    SaveURL = @"E:\TestingDownload\hahaha.mp3"
            //};
            //downloadControl.Download();
        }

        private void StackPanel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            StackPanel panel = (StackPanel)sender;
            PlayingForm playing = new PlayingForm();
            TextBlock block = (TextBlock)panel.Children[0];
            playing.SongID = "S" + block.Text;
            Parrent.Content = playing.Content;
        }
    }
}
