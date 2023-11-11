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
    /// Логика взаимодействия для RegisterPage.xaml
    /// </summary>
    public partial class RegisterPage : Page
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Data.users users = new Data.users()
            {
                fio = FioText.Text,
                login = LoginText.Text,
                password = PasswordText.Text,
                role_id=null
            };
            MessageBox.Show(users.ToString());
            Data.postappEntities.GetContext().users.Add(users);
            Data.postappEntities.GetContext().SaveChanges();
        }
    }
}
