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
using System.Data.SqlClient;//Ado.net class library
using System.Text.RegularExpressions;
using System.Data;

namespace Ola_cabs
{
    /// <summary>
    /// Interaction logic for LoginDriver.xaml
    /// </summary>
    public partial class LoginDriver : Window
    {
        public LoginDriver()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        public string Connection_String { get; private set; }
        public string Command { get; private set; }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-T1C7NC0\\SENETH;Initial Catalog=OLA_CABS;Integrated Security=True");

        }

        private void Logindriver_close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SignupDriver obj = new SignupDriver();
            obj.Show();
            this.Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ForgetPasswordDriver obj = new ForgetPasswordDriver();
            obj.Show();
            this.Close();
        }

        private void Sign_in_btn_Click(object sender, RoutedEventArgs e)
        {

            if (string.IsNullOrEmpty(Username1.Text))
            {
                MessageBox.Show(this, "Usename cannot be blank", "info", MessageBoxButton.OK);
                Username1.Focus();
            }
           
            else if (Password1.Password.Length == 0)
            {

                MessageBox.Show(this, "Please Enter your Password", "info", MessageBoxButton.OK);
                Password1.Focus();
            }
            else
            {
            
                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*)FROM DRIVER_LOGIN WHERE DRIVER_NAME='" + Username1.Text + "' AND PASSWORD='" + Password1.Password + "'", con);
                /* in above line the program is selecting the whole data from table and the matching it with the user name and password provided by user. */
                DataTable dt = new DataTable(); //this is creating a virtual table  
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show(this, " login sucssess !  ", "info", MessageBoxButton.OK);


                }
                else
                {
                    MessageBox.Show(this, "login falied !", "info", MessageBoxButton.OK);
                }

            }




        }


        }
          



    }


