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

namespace WpfPost.Pages
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

     

        private void LoginButton_Click_1(object sender, RoutedEventArgs e)
        {
            if (Data.postappEntities.GetContext().users.Any(d => d.login == LoginTextBox.Text && d.password == PasswordBox.Text))
            {
                Classes.FrameNavigate.CurrentUser = Data.postappEntities.GetContext().users
                    .Where(d => d.login == LoginTextBox.Text && d.password == PasswordBox.Text).FirstOrDefault();
                MessageBox.Show("Успешный вход", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                switch (Classes.FrameNavigate.CurrentUser.role_id)
                {
                    case 1:
                        Classes.FrameNavigate.MainFrame.Navigate(new Pages.CustomerPage());
                        break;
                    case 2:
                        Classes.FrameNavigate.MainFrame.Navigate(new Pages.AdminPage());
                        break;
                    case 3:
                     
                        break;
                }
            }
            else
            {
                MessageBox.Show("Неверный логин/пароль", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                //Captcha();
            }
        }

        private void RegisterButton1_Click(object sender, RoutedEventArgs e)
        {
            Classes.FrameNavigate.MainFrame.Navigate(new Pages.RegisterPage());
        }
    }
}
