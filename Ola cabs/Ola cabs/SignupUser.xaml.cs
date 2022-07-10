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
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Ola_cabs
{
    /// <summary>
    /// Interaction logic for SignupUser.xaml
    /// </summary>
    public partial class SignupUser : Window
    {
        public SignupUser()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlCommand cmd;

        private void signup_close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Sign_up_return_Click(object sender, RoutedEventArgs e)
        {
            LoginUser obj = new LoginUser();
            obj.Show();
            this.Hide();
        }

        private void signup_user_btn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(F_name.Text))
            {
                MessageBox.Show(this, "First Name cannot be blank", "info", MessageBoxButton.OK);
                F_name.Focus();


            }
            else if (F_name.Text.Any(Char.IsDigit))
            {
                MessageBox.Show(this, "First Name cannot have numbers", "info", MessageBoxButton.OK);
                F_name.Focus();

            }
            
            else if (Email.Text.Length == 0)
            {


                MessageBox.Show(this, "Please Enter Email Address", "info", MessageBoxButton.OK);
                Email.Focus();


            }
            else if (!Regex.IsMatch(Email.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {

                MessageBox.Show(this, "Enter a valid email (name@gmail.com)", "info", MessageBoxButton.OK);
                Email.Focus();


            }
            else if (Password.Password.Length == 0)
            {

                MessageBox.Show(this, "Please Enter your Password", "info", MessageBoxButton.OK);
                Password.Focus();
            }
            else if (Conform_password_.Password.Length == 0)
            {

                MessageBox.Show(this, "Please Enter your Conform Password", "info", MessageBoxButton.OK);
                Conform_password_.Focus();
            }
            else if (Password.Password != Conform_password_.Password)
            {
                MessageBox.Show(this, "Confirm Password must same as the Password", "info", MessageBoxButton.OK);
                Conform_password_.Focus();

            }
            else
            {


                con = new SqlConnection("Data Source=DESKTOP-T1C7NC0\\SENETH;Initial Catalog=OLA_CABS;Integrated Security=True");


                try
                {
                   

                    con.Open();

                    cmd = new SqlCommand("Insert Into USER_LOGIN values('" + F_name.Text + "','" + Email.Text + "','" + Password.Password + "','" + Conform_password_.Password + "')", con);




                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)


                        MessageBox.Show(this, "data save succsessfully", "info", MessageBoxButton.OK);
                    
                    
                    else
                        MessageBox.Show(this, "data cannot save", "info", MessageBoxButton.OK);
                    con.Close();
                    User_info obj = new User_info();
                    obj.Show();
                    this.Hide();
                        


                }
                catch (SqlException)
                {
                    MessageBox.Show(this, "Database Error ", "info", MessageBoxButton.OK);

                }

                catch (Exception)
                {

                    MessageBox.Show(this, "check details ", "info", MessageBoxButton.OK);

                }

                

            }
        } 
    }
}
