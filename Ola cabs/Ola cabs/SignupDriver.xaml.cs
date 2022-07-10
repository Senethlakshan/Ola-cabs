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



namespace Ola_cabs
{
    /// <summary>
    /// Interaction logic for SignupDriver.xaml
    /// </summary>
    public partial class SignupDriver : Window
    {
        public SignupDriver()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlCommand cmd;

        private void Sign_in_return_Click(object sender, RoutedEventArgs e)
        {
            LoginDriver obj = new LoginDriver();
            obj.Show();
            this.Hide();
        }

        private void Signup_close1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }





        private void Register_btn_Click(object sender, RoutedEventArgs e)
        {


            if (string.IsNullOrEmpty(Username_1.Text))
            {
                MessageBox.Show(this, "First Name cannot be blank", "info", MessageBoxButton.OK);
                Username_1.Focus();


            }
            else if (Username_1.Text.All(c => Char.IsLetterOrDigit(c)))
            {
                MessageBox.Show(this, "Username only letters and numbers", "info", MessageBoxButton.OK);
                Username_1.Focus();
            }
            


            else if (email_1.Text.Length == 0)
            {
                MessageBox.Show(this, "Please Enter Email Address", "info", MessageBoxButton.OK);
                email_1.Focus();


            }
            else if (!Regex.IsMatch(email_1.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {

                MessageBox.Show(this, "Enter a valid email (name@gmail.com)", "info", MessageBoxButton.OK);
                email_1.Focus();


            }
            else if (password_1.Password.Length == 0)
            {

                MessageBox.Show(this, "Please Enter your Password", "info", MessageBoxButton.OK);
                password_1.Focus();
            }
            else if (c_password_1.Password.Length == 0)
            {

                MessageBox.Show(this, "Please Enter your Conform Password", "info", MessageBoxButton.OK);
                c_password_1.Focus();
            }
            else if (password_1.Password != c_password_1.Password)
            {
                MessageBox.Show(this, "Confirm Password must same as the Password", "info", MessageBoxButton.OK);
                c_password_1.Focus();

            }
            else
            {


                con = new SqlConnection("Data Source=DESKTOP-T1C7NC0\\SENETH;Initial Catalog=OLA_CABS;Integrated Security=True");


                try
                {

                    con.Open();

                    cmd = new SqlCommand("Insert Into DRIVER_LOGIN values('" + Username_1.Text + "','" + email_1.Text + "','" + password_1.Password + "','" + c_password_1.Password + "')", con);




                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)


                        MessageBox.Show(this, "data save succsessfully", "info", MessageBoxButton.OK);
                    else
                        MessageBox.Show(this, "data cannot save", "info", MessageBoxButton.OK);
                    con.Close();


                }
                catch (SqlException)
                {
                    MessageBox.Show(this, "Database Error ", "info", MessageBoxButton.OK);

                }

                catch (Exception)
                {

                    MessageBox.Show(this, "check details ", "info", MessageBoxButton.OK);

                }


                Driver_info obj = new Driver_info();
                obj.Show();
                this.Close();



            }

        }

        
    }
}
    


 

    












