/* ================
Web Service SOAP
================= */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebServicePractice
{
    public partial class frmApp : Form
    {
        public frmApp()
        {
            InitializeComponent();
            lblResult.Text = "";
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            var city = txtCity.Text.Trim();
            var country = txtCountry.Text.Trim();

            if (city != String.Empty && country != String.Empty)
            {
                WeatherWebService.GlobalWeatherSoapClient client = new WeatherWebService.GlobalWeatherSoapClient();
                var res = client.GetWeather(txtCity.Text, txtCountry.Text);
                lblResult.Text = res;
            }
            else
            {
                MessageBox.Show("Please Enter The City and Country");
            }
        }
    }
}
