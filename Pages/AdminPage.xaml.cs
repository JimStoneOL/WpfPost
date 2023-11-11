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
    /// Логика взаимодействия для AdminPage.xaml
    /// </summary>
    public partial class AdminPage : Page
    {
        public List<Data.posts> _posts = Data.postappEntities.GetContext().posts.ToList();
        public AdminPage()
        {
            InitializeComponent();
            PostListView.Items.Clear();
            PostListView.ItemsSource = Data.postappEntities.GetContext().posts.ToList();
         
        }
    
    }
}
