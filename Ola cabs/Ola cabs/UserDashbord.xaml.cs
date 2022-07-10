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

namespace Ola_cabs
{
    /// <summary>
    /// Interaction logic for UserDashbord.xaml
    /// </summary>
    public partial class UserDashbord : Window
    {
        public UserDashbord()
        {
            InitializeComponent();
        }


        
    

        TabItem _tabUserPage;
        private void RIDE_Click(object sender, RoutedEventArgs e)
        {

            MainTab.Items.Clear(); //Clear previous Items in the user controls which is my tabItems    
            var userControls = new UserControl1();
            _tabUserPage = new TabItem { Content = userControls };
            MainTab.Items.Add(_tabUserPage); // Add User Controls    
            MainTab.Items.Refresh();

        }

        private void USER_DETAILS_Click(object sender, RoutedEventArgs e)
        {
            MainTab.Items.Clear(); //Clear previous Items in the user controls which is my tabItems    
            var userControls = new UserControl2();
            _tabUserPage = new TabItem { Content = userControls };
            MainTab.Items.Add(_tabUserPage); // Add User Controls    
            MainTab.Items.Refresh();
        }

        private void S_RIDE_Click(object sender, RoutedEventArgs e)
        {
            MainTab.Items.Clear(); //Clear previous Items in the user controls which is my tabItems    
            var userControls = new UserControl3();
            _tabUserPage = new TabItem { Content = userControls };
            MainTab.Items.Add(_tabUserPage); // Add User Controls    
            MainTab.Items.Refresh();
        }

        private void MAP_Click(object sender, RoutedEventArgs e)
        {
            MainTab.Items.Clear(); //Clear previous Items in the user controls which is my tabItems    
            var userControls = new UserControl4();
            _tabUserPage = new TabItem { Content = userControls };
            MainTab.Items.Add(_tabUserPage); // Add User Controls    
            MainTab.Items.Refresh();
        }

        private void ride_info_Click(object sender, RoutedEventArgs e)
        {
            MainTab.Items.Clear(); //Clear previous Items in the user controls which is my tabItems    
            var userControls = new UserControl5();
            _tabUserPage = new TabItem { Content = userControls };
            MainTab.Items.Add(_tabUserPage); // Add User Controls    
            MainTab.Items.Refresh();
        }

        private void INVOICE_Click(object sender, RoutedEventArgs e)
        {
            MainTab.Items.Clear(); //Clear previous Items in the user controls which is my tabItems    
            var userControls = new UserControl6();
            _tabUserPage = new TabItem { Content = userControls };
            MainTab.Items.Add(_tabUserPage); // Add User Controls    
            MainTab.Items.Refresh();
        }

        private void HELP_Click(object sender, RoutedEventArgs e)
        {
            MainTab.Items.Clear(); //Clear previous Items in the user controls which is my tabItems    
            var userControls = new UserControl7();
            _tabUserPage = new TabItem { Content = userControls };
            MainTab.Items.Add(_tabUserPage); // Add User Controls    
            MainTab.Items.Refresh();
        }

        private void close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
