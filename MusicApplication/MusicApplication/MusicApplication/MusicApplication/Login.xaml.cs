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
        //truyền Name sang Main
        
        

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string username = tbLoginName.Text;
            string password = tbPassword.Password;
            ServiceReference.ITransfer service = new ServiceReference.TransferClient();
            string name = service.Login(username, password);
            if (name != "") // có giá trị sẽ thông báo thành công
            {
                this.Close();
                nameUser = name;
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
