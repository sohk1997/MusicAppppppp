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
    /// Interaction logic for PersonalPlaylist.xaml
    /// </summary>
    public partial class PersonalPlaylist : UserControl
    {
        List<ServiceReference.Playlist> items;
        ServiceReference.ITransfer transfer;
        ServiceReference.UserInfo user;
        MainWindow parrent;
        public PersonalPlaylist()
        {
            InitializeComponent();
        }

        public UserInfo User { get => user; set => user = value; }
        public MainWindow Parrent { get => parrent; set => parrent = value; }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(txtName.Text.Length == 0)
            {
                MessageBox.Show("Please enter name of playlist");
                return;
            }
            transfer = new TransferClient();
            ServiceReference.Playlist playlist = new ServiceReference.Playlist();
            playlist.Creator = user.ID;
            playlist.Name = txtName.Text;
            transfer.AddPlaylist(playlist);
            LoadData();
        }
        public void LoadData()
        {
            transfer = new ServiceReference.TransferClient();
            items = transfer.GetPlaylistByUserID(user.ID).ToList();
            lvPlaylists.ItemsSource = items;
        }

        private void lvPlaylists_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = lvPlaylists.SelectedIndex;
        }

        private void StackPanel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            StackPanel panel = (StackPanel)sender;
            Image image = (Image)panel.Children[0];
            string playListID = image.Tag.ToString();
            ServiceReference.ITransfer transfer = new ServiceReference.TransferClient();
            List<ServiceReference.SongInfo> listOfSong = transfer.GetSongOfPlaylist(playListID).ToList();
            Parrent.textTitle.Text = Parrent.SONG;
            SongControl songControl = new SongControl();
            songControl.Items = listOfSong;
            songControl.LoadData();
            songControl.Parrent = this.Parrent;
            Parrent.Main.Content = songControl.Content; 
        }
    }
}
