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
    public partial class AddStudent : Form
    {
        List<Student> StudentList = new List<Student>();
        //public static string NameOfStudent;               
        public AddStudent()
        {
            InitializeComponent();
        }

        private void btnSaveStudent_Click(object sender, EventArgs e)
        {
            if (StudentName.Text == "" || StudentDOB.Text == "" || StudentId.Text == "" || StudentAddress.Text == "")
            {
                MessageBox.Show("Error Please enter values");
            }
            else
            {
                MainApp.StudentsList.Add(new Student(StudentName.Text, StudentDOB.Text, StudentId.Text, StudentAddress.Text));
                this.Close();
            }

        }

        private void btnCancelStudent_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StudentName_KeyPress(object sender, KeyPressEventArgs e) //error defense wont allow user to enter weird keys not allowed to
        {
            if (!Char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                base.OnKeyPress(e);
            }
        }

        private void StudentId_KeyPress(object sender, KeyPressEventArgs e) //error defense wont allow user to enter weird keys not allowed to
        {
            if (!Char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                base.OnKeyPress(e);
            }
        }
    }
}
