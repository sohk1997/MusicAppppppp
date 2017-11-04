using MusicApplication.ServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            errorName.Content = string.Empty;
            errorUsername.Content = string.Empty;
            errorPassword.Content = string.Empty;
            errorConfirmPassword.Content = string.Empty;
            errorEmail.Content = string.Empty;
            
            bool checkError = true;
            if (txtName.Text.Length == 0)
            {
                errorName.Content = "Tên không được bỏ trống";
                return;
            }
            if (txtUsername.Text.Length < 6)
            {
                errorUsername.Content = "Tài khoản phải từ 6 kí tự trở lên";
                return;
            }
            ITransfer service = new TransferClient();
            if (service.CheckDupUsername(txtUsername.Text))
            {
                MessageBox.Show("hahaha");
                errorUsername.Content = "Tài khoản đã tồn tại";
                return;
            }
            else
                MessageBox.Show("haha1ha");
            //if (txtPassword.Password.Length < 8)
            //{
            //    errorPassword.Content = "Mật khẩu phải từ 8 kí tự trở lên";
            //    return;
            //}
            //if (txtConfirmPassword.Password.Length == 0)
            //{
            //    errorConfirmPassword.Content = "Xác nhận mật khẩu không được bỏ trống";
            //    return;
            //}
            //if (txtConfirmPassword.Password != txtPassword.Password)
            //{
            //    errorConfirmPassword.Content = "Xác nhận mật khẩu không khớp";
            //    return;
            //}
            //if (txtEmail.Text.Length == 0)
            //{
            //    errorEmail.Content = "Email không được bỏ trống";
            //    return;
            //}
            //string pattern = @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
            //Regex r = new Regex(pattern, RegexOptions.IgnoreCase);

            //if (!r.Match(txtEmail.Text).Success)
            //{
            //    errorEmail.Content = "Email không hợp lệ";
            //    return;
            //}

            //string name = txtUsername.Text;
            //string username = txtUsername.Text;
            //string password = txtPassword.Password;
            //string confirmPassword = txtConfirmPassword.Password;
            //string email = txtEmail.Text;

            //if (checkError)
            //{
            //    UserInfo user = new UserInfo();
            //    user.Name = name;
            //    user.Username = username;
            //    user.Password = password;
            //    user.Email = email;

            //    bool result = false;
            //    try
            //    {
            //        result = service.Register(user);

            //    }
            //    catch (Exception)
            //    {
            //        errorUsername.Content = "Tài khoản đã tồn tại";
            //        throw new Exception();
            //    }

            //    if (result)
            //    {
            //        MessageBox.Show("Bạn vừa tạo tài khoản thành công!");
            //        this.Close();
            //    }
            //    else
            //        MessageBox.Show("Đăng ký không thành công!");
            //}

        }
        }
}
