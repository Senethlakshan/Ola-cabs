using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ola_cabs
{
    public partial class Uc1Form1 : Form
    {
        public Uc1Form1()
        {
            InitializeComponent();
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        string locate1;
        string locate2;

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
            //invalid
        }

        private void Uc1Form1_Load(object sender, EventArgs e)
        {
           locate1 = UserControl1.SetValueForText2;
            locate2 = UserControl1.SetValueForText3;
            string city = locate1;
            string city1 = locate2;


            StringBuilder queryaddress = new StringBuilder();
            queryaddress.Append("http://google.com/maps?q=");



            if (city != string.Empty)
            {
                queryaddress.Append(city + "," + ",");

            }

            if (city != string.Empty)
            {
                queryaddress.Append(city + "," + ",");

            }

            webBrowser1.Navigate(queryaddress.ToString());


        }
    }
}
