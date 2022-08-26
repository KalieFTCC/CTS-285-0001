using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/**
* 8/17/2022
* CSC 253
* Kalie Kirch
* Converts the temperature in Celcius to it's Fahrenheit Equivalent. 
*/


namespace Fahrenheit_to_Celsius
{
    public partial class FahrenheitConversionTable : Form
    {
        public FahrenheitConversionTable()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            const int minTemp = 0;
            const int maxTemp = 20;
            decimal f;

            tempLst.Items.Add("         CELSIUS \t         FAHRENHEIT");
            for (int i = minTemp; i <= maxTemp; i++)
            {
                f = (9m / 5) * i + 32;
                tempLst.Items.Add("\t" + i + "\t\t" + f );

                /*
                 * for Fahrenheit to Celcius it's 
                 * C = (5 / 9) * (f - 32);
                 */
            }
        }
        private void FahrenheitConversionTable_Load(object sender, EventArgs e)
        {

        }

    }
}
