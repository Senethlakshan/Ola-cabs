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
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Data;

namespace Ola_cabs
{
    /// <summary>
    /// Interaction logic for UserControl2.xaml
    /// </summary>
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        string usname = LoginUser.SetValueForText4;

        SqlConnection con;
  
        private void Button_Click(object sender, RoutedEventArgs e)
        {
         
                con = new SqlConnection("Data Source=DESKTOP-T1C7NC0\\SENETH;Initial Catalog=OLA_CABS;Integrated Security=True");

            con.Open();

             SqlCommand cmd=new SqlCommand(" SELECT*FROM User_info WHERE FULLNAME='" + usname + "')", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgrid1.ItemsSource =dt.DefaultView;
            con.Close();
        }
    }
}
