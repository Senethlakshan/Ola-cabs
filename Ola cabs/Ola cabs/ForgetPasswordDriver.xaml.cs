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
    /// Interaction logic for ForgetPasswordDriver.xaml
    /// </summary>
    public partial class ForgetPasswordDriver : Window
    {
        public ForgetPasswordDriver()
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

        private void FPD_close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void FPdriver_Click(object sender, RoutedEventArgs e)

        {

            if (string.IsNullOrEmpty(username3.Text))
            {
                MessageBox.Show(this, "First Name cannot be blank", "info", MessageBoxButton.OK);
                username3.Focus();


            }
            
            else if (NewPassword_2.Password.Length == 0)
            {

                MessageBox.Show(this, "Please Enter your new Password", "info", MessageBoxButton.OK);
                NewPassword_2.Focus();
            }
            else if (NewPassword_2.Password != ConformPassword_2.Password)
            {
                MessageBox.Show(this, "Confirm Password is wrong !", "info", MessageBoxButton.OK);
                ConformPassword_2.Focus();

            }
            else
            {
                try
                {

                    con.Open();

                    cmd = new SqlCommand("UPDATE DRIVER_LOGIN SET PASSWORD ='"+NewPassword_2.Password+ "' , CONFORM_PASSWORD='"+ConformPassword_2.Password+"'  WHERE DRIVER_NAME='"+username3.Text+"'", con);




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




            }
        }

        
    }
}
