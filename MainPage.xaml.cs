using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace tc
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

        /// <summary>
        /// Runs when button is clicked, converts the temperature
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void convert_click(object sender, EventArgs e)
        {
            double temp = 0;
            double.TryParse(conversionValue.Text, out temp);
            //determine the conversion type and convert
            string convType =  Conversion.Items[Conversion.SelectedIndex];
            // txtOutput.Text = temp.ToString();
            if (convType.Equals("C to F"))
            {
                txtOutput.Text = (temp * 9 / 5 + 32).ToString();
            }
            else {
                txtOutput.Text = ((temp - 32) / (9.0 / 5.0)).ToString();
            }
            //txtOutput.Text = convType;
        }
    }
}
