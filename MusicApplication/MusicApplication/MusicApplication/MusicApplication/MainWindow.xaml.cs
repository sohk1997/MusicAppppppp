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
        private readonly string SONG = "BÀI HÁT";
        private readonly string ARTIST = "NGHỆ SĨ";
        private readonly string UPLOAD = "TẢI LÊN";
        private readonly string DOWNLOAD = "TẢI XUỐNG";
        private readonly string HOME = "TRANG CHỦ";


        public MainWindow()
        {
            InitializeComponent();
            Home homeControl = new Home();
            Main.Content = homeControl.Content;
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
            songControl.Parrent = this;
            Main.Content = songControl.Content;

        }

        private void btnSong_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void btnArtist_Click(object sender, RoutedEventArgs e)
        {
            textTitle.Text = ARTIST;
            ArtistControl artistControl = new ArtistControl();
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
            textTitle.Text = UPLOAD;
            UploadControl uploadControl = new UploadControl();
            Main.Content = uploadControl.Content;
        }

    }
}
