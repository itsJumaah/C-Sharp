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
    public partial class Enrol : Form
    {
        public Enrol()
        {
            InitializeComponent();
        }
        //defining the lists
        private List<Student> EnrollStudentsList = new List<Student>();
        private List<Paper> EnrollPapersList = new List<Paper>();

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (EnrolStudent.Text == "" || EnrolPaper.Text == "") //error checking
            {
                MessageBox.Show("Input required in each Text Box");//error
            }
            if (EnrolStudent.Text != "" && EnrolPaper.Text != "") //if no error proceed with the enrollment
            {
                MainApp.EnrolledStudentsList.Add(new EnrollStudents(EnrolStudent.Text, EnrolPaper.Text));
                MainApp.EnrolledPapersList.Add(new EnrollPapers(EnrolStudent.Text, EnrolPaper.Text));
                this.Close();
            }
            this.Close(); 
        }

        private void Enrol_Load(object sender, EventArgs e)
        {
            int counter = 0;
            foreach (Student s in MainApp.StudentsList) //loop goes to each element in the list
            {
                string both = null; //new string to mix the id and the name after analysing
                both = s.ToString() + " - " + s.getId(); //mxing to add them and making it look nicely
                EnrolStudent.Items.Insert(counter, both);  //adding to the combo box drop down list
                counter++;
            }
            int counterTwo = 0;
            foreach (Paper s in MainApp.PaperList) //exactly same as above loop but for papers comobo box 
            {
                string both = null;
                both = s.ToString() + " - " + s.getpapername();
                EnrolPaper.Items.Insert(counterTwo, both);
                counterTwo++;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();  //cancel button closes the form
        }
    }
}
