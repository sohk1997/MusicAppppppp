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
using MusicApplication.ServiceReference;

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
        public List<SongInfo> Items { get => items; set => items = value; }
        public void LoadData()
        {
            lvSongs.ItemsSource = items;
        }
        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var fileDialog = new System.Windows.Forms.SaveFileDialog();
            if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.Windows.Controls.Image image = (System.Windows.Controls.Image)sender;
                DownloadSong downloadControl = new DownloadSong()
                {

                    SongID = "S" + image.Tag.ToString(),
                    SaveURL = fileDialog.FileName + ".mp3"
                };
                downloadControl.Download();
            }
        }

        private void StackPanel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            StackPanel panel = (StackPanel)sender;
            PlayingForm playing = new PlayingForm();
            TextBlock block = (TextBlock)panel.Children[0];
            playing.SongID = "S" + block.Text;
            playing.ShowDialog();
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            PlaylistPopup plPopup = new PlaylistPopup();
            plPopup.ShowDialog();
        }
    }
}
