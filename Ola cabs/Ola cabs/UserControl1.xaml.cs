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


namespace Ola_cabs
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        public static string SetValueForText2 = "";
        public static string SetValueForText3 = "";

      
        public static string picklocate = "";
        public static string droplocate = "";
        public static string kmofcus = "";
        public static double billa;

       
      

        SqlConnection con;
        SqlCommand cmd;

        User_ride new_user = new User_ride();


        private void findlocate1_Click(object sender, RoutedEventArgs e)
        {
            SetValueForText2 = pik1.Text;
            SetValueForText3 = drop1.Text;

            Uc1Form1 obj1 = new Uc1Form1();
            obj1.Show();
        }


        private void insertDatabase()
        {
            con = new SqlConnection("Data Source=DESKTOP-T1C7NC0\\SENETH;Initial Catalog=OLA_CABS;Integrated Security=True");


            try
            {


                con.Open();

                cmd = new SqlCommand("Insert Into USER_RIDE_INFO values('" + usern1.Text + "','" + pik1.Text + "','" + drop1.Text + "','" + numofkm1.Text + "','" + datepil1.Text + "','"+timepick1.Text +"')", con);




                int i = cmd.ExecuteNonQuery();
                if (i == 1)


                    MessageBox.Show( "data save succsessfully", "info", MessageBoxButton.OK);
                else
                    MessageBox.Show( "data cannot save", "info", MessageBoxButton.OK);
                con.Close();


            }
            catch (SqlException)
            {
                //MessageBox.Show("data save succsessfully ", "info", MessageBoxButton.OK);

            }

            catch (Exception)
            {

                MessageBox.Show( "check details ", "info", MessageBoxButton.OK);

            }



        }

        
            
        private void Calculate()
        {
            double tot = 0;

            if (bike1.IsChecked == true)
            {


                double km = Convert.ToDouble(numofkm1.Text);
                double unit_consumeOfKm = 25;
                double sd_rate = 30;
                new_user.userdata(km, unit_consumeOfKm, sd_rate);
                tot = new_user.Calculate();
               





            }
            else if (threwwl1.IsChecked == true)
            {
                double km = Convert.ToDouble(numofkm1.Text);
                double unit_consumeOfKm = 30;
                double sd_rate = 40;
                new_user.userdata(km, unit_consumeOfKm, sd_rate);
                tot = new_user.Calculate();


            }
            else if (car1.IsChecked == true)
            {
                double km = Convert.ToDouble(numofkm1.Text);
                double unit_consumeOfKm = 40;
                double sd_rate = 50;
                new_user.userdata(km, unit_consumeOfKm, sd_rate);
                tot = new_user.Calculate();


            }
            else if (van1.IsChecked == true)
            {
                double km = Convert.ToDouble(numofkm1.Text);
                double unit_consumeOfKm = 50;
                double sd_rate = 65;
                new_user.userdata(km, unit_consumeOfKm, sd_rate);
                tot = new_user.Calculate();


            }
            else if (lorry1.IsChecked == true)
            {

                double km = Convert.ToDouble(numofkm1.Text);
                double unit_consumeOfKm = 60;
                double sd_rate = 75;
                new_user.userdata(km, unit_consumeOfKm, sd_rate);
                tot = new_user.Calculate();


            }

            picklocate = pik1.Text;
            droplocate = drop1.Text;
            kmofcus = numofkm1.Text;
            billa = tot;

            Display_bill bill = new Display_bill();
            bill.Show();




       }


        private void conform_Click(object sender, RoutedEventArgs e)
        {


            insertDatabase();
            Calculate();
            




        }
    }
}
