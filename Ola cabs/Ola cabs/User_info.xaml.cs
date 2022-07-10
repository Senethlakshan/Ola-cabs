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
using Microsoft.Win32;

namespace Ola_cabs
{
    /// <summary>
    /// Interaction logic for User_info.xaml
    /// </summary>
    /// 


    public partial class User_info : Window
    {



        public User_info()
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



        private void uInfo_close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void upload_photo_Click(object sender, RoutedEventArgs e)
        {
                try
                {

                    OpenFileDialog open = new OpenFileDialog();
                    if (open.ShowDialog() == true)
                    {
                        Uri location = new Uri(open.FileName);
                        User_imgUpload.Source = new BitmapImage(location);

                    }
                }
                catch (NotSupportedException)
                {

                    MessageBox.Show("Please check again an image only ", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

                }
                catch (Exception)
                {
                    MessageBox.Show("Please check again !", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }


            
        }

        private void submit_Click(object sender, RoutedEventArgs e)
        {

            try
            {

                con.Open();

                cmd = new SqlCommand("Insert Into User_info values('" + FullName.Text + "','" + User_imgUpload.Source + "','" + province1.Text + "','" + address1.Text + "','" + address2.Text + "','" + tele.Text + "','"+Gender1.Text+"')", con);


                int i = cmd.ExecuteNonQuery();
                if (i == 1)


                    MessageBox.Show(this, "data save succsessfully", "info", MessageBoxButton.OK);
                else
                    MessageBox.Show(this, "data cannot save", "info", MessageBoxButton.OK);
                con.Close();

                LoginUser obj = new LoginUser();
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

            LoginUser obj1 = new LoginUser();
            obj1.Show();
            this.Hide();

        }
    }



}


