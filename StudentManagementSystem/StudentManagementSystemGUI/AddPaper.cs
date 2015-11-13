using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentManagementSystem;

namespace StudentManagementSystemGUI
{
    
    public partial class AddPaper : Form
    {
        List<Paper> PapersList = new List<Paper>();
                            
        public AddPaper()
        {
            InitializeComponent();
        }
        private void btnSavePaper_Click(object sender, EventArgs e)
        {
            if (PaperName.Text == "" || PaperNumber.Text == "" || PaperCo.Text == "")
            {
                MessageBox.Show("Error Please enter values"); //error validation
            }
            else
            {
                MainApp.PaperList.Add(new Paper(PaperName.Text, PaperNumber.Text, PaperCo.Text));
                this.Close();
            }

        }

        private void btnCancelPaper_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PaperName_KeyPress(object sender, KeyPressEventArgs e) //error defensive, no weird keys
        {
            if (!Char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                base.OnKeyPress(e);
            }
        }

        private void PaperNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;                                    //input validation 
            if (ch == 46 && PaperNumber.Text.IndexOf('.') != -1) //46 is ascii for "." 
            {
                e.Handled = true;
                return;
            }
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)       //8 is ascii for backspace. 
            {
                e.Handled = true;
            }
        }

        private void PaperCo_KeyPress(object sender, KeyPressEventArgs e) //error defensive, no weird keys
        {
            if (!Char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                base.OnKeyPress(e);
            }
        }

    }
}
