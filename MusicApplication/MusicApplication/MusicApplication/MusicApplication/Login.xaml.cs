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
using MusicApplication.ServiceReference;

namespace MusicApplication
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }
        //truyền Name sang Main
        public string nameUser = "";
        public bool isChanged = true;
        private ServiceReference.UserInfo user;

        public UserInfo User { get => user; set => user = value; }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string username = tbLoginName.Text;
            string password = tbPassword.Password;
            ServiceReference.ITransfer service = new ServiceReference.TransferClient();
            user = service.Login(username, password);
            if (user.Name != null && user.Name.Length != 0) // có giá trị sẽ thông báo thành công
            {
                this.Close();
                nameUser = user.Name;
                invalidText.Text = "";
                isChanged = true;
                MessageBox.Show("Đăng nhập thành công");

            }
            else
            {
                invalidText.Text = "Tên đăng nhập hoặc mật khẩu không đúng!";
            }
                
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            isChanged = false;
        }
    }
}
