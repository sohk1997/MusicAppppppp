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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public readonly string SONG = "BÀI HÁT";
        public readonly string ARTIST = "NGHỆ SĨ";
        public readonly string UPLOAD = "TẢI LÊN";
        public readonly string HOME = "TRANG CHỦ";
        public readonly string MYPLAYLIST = "NHẠC CỦA TÔI";
        public readonly string PLAYLIST = "PLAYLIST | ALBUM";
        private ServiceReference.UserInfo user = null;

        public MainWindow()
        {
            InitializeComponent();
            Home homeControl = new Home();
            Main.Content = homeControl.Content;
            this.Closing += MainWindow_Closing;
        }

        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Main.Content = null;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Playing pl = new Playing();
            Main.Content = pl.Content;
        }

        private void uLogin_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
            if (login.isChanged)
            {
                uName.Text = login.nameUser;
                uLogout.Text = "Đăng xuất";
                uLogin.Text = "";
                uRegister.Text = "";
                user = login.User;
                textTitle.Text = HOME;
                Home homeControl = new Home();
                Main.Content = homeControl.Content;
            }
        }

        private void uRegister_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Register register = new Register();
            register.ShowDialog();
        }

        private void btnSong_Click(object sender, RoutedEventArgs e)
        {
            textTitle.Text = SONG;
            SongControl songControl = new SongControl();
            songControl.Parrent = Main;
            if (user != null)
            {
                songControl.UserId = user.ID;
            }
            Main.Content = songControl.Content;

        }


        private void btnArtist_Click(object sender, RoutedEventArgs e)
        {
            textTitle.Text = ARTIST;
            ArtistControl artistControl = new ArtistControl();
            artistControl.Parrent = this;
            if (user != null)
            {
                artistControl.UserID = user.ID;
            }
            Main.Content = artistControl.Content;
        }

        private void uLogout_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var result = MessageBox.Show("Bạn có muốn đăng xuất?", "Thông báo", MessageBoxButton.OKCancel);
            if (result == MessageBoxResult.OK)
            {
                uName.Text = "";
                uLogout.Text = "";
                uLogin.Text = "Đăng nhập";
                uRegister.Text = "Đăng ký";
                user = null;
            }
        }
        private void uName_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void btnMenuShow_Click(object sender, RoutedEventArgs e)
        {
            btnMenuHidden.Height = 40;
            btnMenuShow.Height = 0;
        }

        private void btnMenuHidden_Click(object sender, RoutedEventArgs e)
        {
            btnMenuHidden.Height = 0;
            btnMenuShow.Height = 40;

        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            textTitle.Text = HOME;
            Home homeControl = new Home();
            Main.Content = homeControl.Content;
        }

        private void btnUpload_Click(object sender, RoutedEventArgs e)
        {
            if(user == null)
            {
                MessageBox.Show("Please login to use this");
                return;
            }
            textTitle.Text = UPLOAD;
            UploadControl uploadControl = new UploadControl();
            uploadControl.UserID = int.Parse(user.ID);
            Main.Content = uploadControl.Content;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(lbSearch.Text.Length == 0)
            {
                MessageBox.Show("Please enter some name of song to search");
                return;
            }
            textTitle.Text = SONG;
            SongControl songControl = new SongControl();
            ServiceReference.ITransfer transfer = new ServiceReference.TransferClient();
            songControl.Items = transfer.FindSongLikeName(lbSearch.Text).ToList();
            songControl.Parrent = Main;
            songControl.LoadData();
            if(user != null)
            {
                songControl.UserId = user.ID;
            }
            Main.Content = songControl.Content;
        }

        private void myPlaylist_Click(object sender, RoutedEventArgs e)
        {
            if (user == null)
            {
                MessageBox.Show("Please login to use this");
                return;
            }
            textTitle.Text = MYPLAYLIST;
            PersonalPlaylist myPlaylistControl = new PersonalPlaylist();
            myPlaylistControl.User = user;
            myPlaylistControl.LoadData();
            myPlaylistControl.Parrent = this;
            Main.Content = myPlaylistControl.Content;
        }

        private void btnAlbum_Click(object sender, RoutedEventArgs e)
        {
            textTitle.Text = PLAYLIST;
            PlaylistControl playlistControl = new PlaylistControl();
            Main.Content = playlistControl.Content;
        }
    }
}
