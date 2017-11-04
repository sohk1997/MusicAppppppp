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
        List<ServiceReference.Playlist> pls = new List<ServiceReference.Playlist>();
        private string songID;
        public PlaylistPopup()
        {
            InitializeComponent();
        }

        public string SongID { get => songID; set => songID = value; }

        public void LoadData(string userID)
        {
            ServiceReference.ITransfer transfer = new ServiceReference.TransferClient();
            pls = transfer.GetPlaylistByUserID(userID).ToList();
            lvPlaylists.ItemsSource = pls;
        }

        private void lvPlaylists_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(MessageBox.Show("Bạn muốn thêm vào playlist này?","Xác nhận",MessageBoxButton.YesNo) == MessageBoxResult.No)
            {
                return;
            }
            else
            {
                int index = lvPlaylists.SelectedIndex;
                string playlistID = pls.ElementAt(index).ID;
                ServiceReference.ITransfer transfer = new ServiceReference.TransferClient();
                int ans = transfer.AddSongToPlaylist(SongID, playlistID);
                if(ans == 1)
                {
                    MessageBox.Show("Thêm vào playlist thành công");
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra. Xin thử lại");
                }
                this.Close();
            }
        }
    }
}
