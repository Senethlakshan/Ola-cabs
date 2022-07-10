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
    /// Interaction logic for LoginUser.xaml
    /// </summary>
    public partial class LoginUser : Window
    {
        public LoginUser()
        {
            InitializeComponent();
        }

   


        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        public static string SetValueForText4 = "";

        public string Connection_String { get; private set; }
        public string Command { get; private set; }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-T1C7NC0\\SENETH;Initial Catalog=OLA_CABS;Integrated Security=True");
        }

        private void user_close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SignupUser obj = new SignupUser();
            obj.Show();
            this.Hide();
        }

        private void Forget_password_user_Click(object sender, RoutedEventArgs e)
        {
            ForgetPasswordUser obj = new ForgetPasswordUser();
            obj.Show();
            this.Close();
        }

        private void Sign_up_user_Click(object sender, RoutedEventArgs e)
        {


            if (string.IsNullOrEmpty(username2.Text))
            {
                MessageBox.Show(this, "Usename cannot be blank", "info", MessageBoxButton.OK);
                username2.Focus();
            }

            else if (password2.Password.Length == 0)
            {

                MessageBox.Show(this, "Please Enter your Password", "info", MessageBoxButton.OK);
                password2.Focus();
            }
            else
            {

                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*)FROM USER_LOGIN WHERE USERNAME='" + username2.Text + "' AND PASSWORD='" + password2.Password + "'", con);
               
                DataTable dt = new DataTable(); //this is creating a virtual table  
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                   MessageBox.Show(this, " login sucssess !  ", "info", MessageBoxButton.OK);

                    SetValueForText4 = username2.Text;

                    sms user = new sms();
                    user.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show(this, "login falied !", "info", MessageBoxButton.OK);
                }

            }

        }
    }
}
