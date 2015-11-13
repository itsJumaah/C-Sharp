using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class CurrencyConverterForm : Form
    {
        double amount = 0, result = 0, NZD = 1.36, USD = 1, AUD = 1.31, CAD = 1.28, EUR = 0.95,GBP = 0.68, TOconstant = 0, FROMconstant = 0;
        public CurrencyConverterForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            from.Text = fromNZD.Text;
            FROMconstant = NZD;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            from.Text = fromEUR.Text;
            FROMconstant = EUR;
        }

        private void fromAUD_Click(object sender, EventArgs e)
        {
            from.Text = fromAUD.Text;
            FROMconstant = AUD;
        }

        private void fromCAD_Click(object sender, EventArgs e)
        {
            from.Text = fromCAD.Text;
            FROMconstant = CAD;
        }

        private void fromGBP_Click(object sender, EventArgs e)
        {
            from.Text = fromGBP.Text;
            FROMconstant = GBP;
        }

        private void fromUSD_Click(object sender, EventArgs e)
        {
            from.Text = fromUSD.Text;
            FROMconstant = USD;
        }

        private void toNZD_Click(object sender, EventArgs e)
        {
            to.Text = toNZD.Text;
            TOconstant = NZD;
        }

        private void toAUD_Click(object sender, EventArgs e)
        {
            to.Text = toAUD.Text;
            TOconstant = AUD;
        }

        private void toEUR_Click(object sender, EventArgs e)
        {
            to.Text = toEUR.Text;
            TOconstant = EUR;
        }

        private void toCAD_Click(object sender, EventArgs e)
        {
            to.Text = toCAD.Text;
            TOconstant = CAD;
        }

        private void toGBP_Click(object sender, EventArgs e)
        {
            to.Text = toGBP.Text;
            TOconstant = GBP;
        }

        private void toUSD_Click(object sender, EventArgs e)
        {
            to.Text = toUSD.Text;
            TOconstant = USD;
        }

        private void reset_Click(object sender, EventArgs e)
        {
            //this will replace all the boxes to their default states
            rowInput.Text = "";
            to.Text = "________";
            from.Text = "________";
            finalResult.Text = "________";
            //this will reset the constants back to zer0
            TOconstant = 0;
            FROMconstant = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void convert_Click(object sender, EventArgs e)
        {
            if (rowInput.Text == "" || rowInput.Text == ".")
            {
                //error msg to make sure the user provide an input with numbers
                MessageBox.Show("ERROR!! **Please enter a valid amount.**\n Please make sure to provide a number");
            }
            else if (FROMconstant == 0)
            {
                //makes sure the user chose to what to convert from
                finalResult.Text = "Please choose a the currency you want to convert from";
            }
            else if (TOconstant == 0)
            {
                //makes sure the use chose what to convert to
                finalResult.Text = "Please choose a the currency you want to convert to";
            }
            else
            {
                amount = (float)(Convert.ToDouble(rowInput.Text)); //converting the input from string to double then to float
                result = TOconstant / FROMconstant * amount; //the equation of conversion
                finalResult.Text = result.ToString("0.00"); //round the result to 2 DP and converting it to a string to be able to print
            }
        }


        private void rowInput_TextChanged_1(object sender, KeyPressEventArgs e)
        {
            //validation for the input box, to make sure the user doesnt enter invalid characters
            //this limits the user to enter only 1 dp and will not accept any characters apart from numbers
            char ch = e.KeyChar;

            if (ch == 46 && rowInput.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void rowInput_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
