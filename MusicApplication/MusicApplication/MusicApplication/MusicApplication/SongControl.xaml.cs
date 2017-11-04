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
        Frame parrent;
        PlayingForm playing = new PlayingForm();
        string userId = "";
        public SongControl()
        {
            InitializeComponent();
            ServiceReference.ITransfer service = new ServiceReference.TransferClient();
            items = service.GetAllSong().ToList();
            lvSongs.ItemsSource = items;
        }

        public Frame Parrent { get => parrent; set => parrent = value; }
        public List<SongInfo> Items { get => items; set => items = value; }
        public string UserId { get => userId; set => userId = value; }

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
            lvSongs.SelectedItem = sender;
            StackPanel panel = (StackPanel)sender;
            
            TextBlock block = (TextBlock)panel.Children[0];
            playing.Items = items;
            playing.SongID = "S" + block.Text;          
            playing.Parent1 = parrent;
            playing.SetRenderEvent();
            int index = lvSongs.SelectedIndex;
            if (index == -1)
            {
                index = 0;
            }
            playing.SelectedIndex = index;
            playing.LoadData();
            parrent.Content = playing.Content;
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if(userId == null || userId.Length == 0)
            {
                MessageBox.Show("Please login to add song to playlist.");
                return;
            }
            PlaylistPopup plPopup = new PlaylistPopup();
            System.Windows.Controls.Image image = (System.Windows.Controls.Image)sender;
            plPopup.SongID = image.Tag.ToString();
            plPopup.LoadData(userId);
            plPopup.ShowDialog();
        }

        private void lvSongs_Selected(object sender, SelectionChangedEventArgs e)
        {
            int index = lvSongs.SelectedIndex;
            if(index == -1)
            {
                index = 0;
            }
            playing.SelectedIndex = index;
            playing.LoadData();
            
        }
    }
}
