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
    /// Interaction logic for ForgetPasswordUser.xaml
    /// </summary>
    public partial class ForgetPasswordUser : Window
    {
        public ForgetPasswordUser()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-T1C7NC0\\SENETH;Initial Catalog=OLA_CABS;Integrated Security=True");
        }


        private void FPU_close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }

        private void updatePassword_Click(object sender, RoutedEventArgs e)
        {

            if (string.IsNullOrEmpty(username4.Text))
            {
                MessageBox.Show(this, "First Name cannot be blank", "info", MessageBoxButton.OK);
                username4.Focus();


            }

            else if (NewPassword_1.Password.Length == 0)
            {

                MessageBox.Show(this, "Please Enter your new Password", "info", MessageBoxButton.OK);
                NewPassword_1.Focus();
            }
            else if (ConformPassword_1.Password != ConformPassword_1.Password)
            {
                MessageBox.Show(this, "Confirm Password is wrong !", "info", MessageBoxButton.OK);
                ConformPassword_1.Focus();

            }
            else
            {
                try
                {

                    con.Open();

                    cmd = new SqlCommand("UPDATE USER_LOGIN SET PASSWORD ='" + NewPassword_1.Password + "' ,   CONFORM_PASSWORD='" + ConformPassword_1.Password + "'  WHERE USERNAME='" + username4.Text + "'", con);




                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)


                        MessageBox.Show(this, "Password update succsessfully", "info", MessageBoxButton.OK);

                  

                    else
                        MessageBox.Show(this, "Password update not succsessfully", "info", MessageBoxButton.OK);
                    con.Close();


                }
                catch (SqlException)
                {
                    MessageBox.Show(this, "Database Error Try again ! ", "info", MessageBoxButton.OK);

                }

                catch (Exception)
                {

                    MessageBox.Show(this, "check details ", "info", MessageBoxButton.OK);

                }

                LoginUser obj1 = new LoginUser();
                obj1.Show();
                this.Hide();
            }
        }
    }
}
