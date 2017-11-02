using MusicApplication.ServiceReference;
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
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btn_Register_Click(object sender, RoutedEventArgs e)
        {
            bool checkError = true;
            string name = txtName.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Password;
            string confirmPassword = txtConfirmPassword.Password;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;

            if (checkError)
            {
                UserInfo user = new UserInfo();
                user.Name = name;
                user.Username = username;
                user.Password = password;
                user.Email = email;
                user.PhoneNumber = phone;

                bool result = false;
                try
                {
                    ITransfer service = new TransferClient();
                    result = service.Register(user);

                }
                catch (Exception)
                {
                    throw new Exception();
                }

                if (result) { 
                    MessageBox.Show("Bạn vừa tạo tài khoản thành công!");
                    this.Close();
                }
                else
                    MessageBox.Show("Sai rồi!");
            }

        }
        }
}
