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
    public partial class MainApp : Form
    {
        //Defining my lists, they're all public and static so they can be accessed in all forms
         public static List<Student> StudentsList = new List<Student>();
         public static List<Paper> PaperList = new List<Paper>();
         public static List<EnrollStudents> EnrolledStudentsList = new List<EnrollStudents>();
         public static List<EnrollPapers> EnrolledPapersList = new List<EnrollPapers>();

        public MainApp()
         {
             InitializeComponent();
         }

        private void MainApp_Load(object sender, EventArgs e)
         {
            University myUniversity = new University();
            lablLogo.Text = myUniversity.Name; //Making a use of the required class (university) and passing the string name of the university and displaying it as a title for the main app interface
            windowToolStripMenuItem.Enabled = false; //disabling unused menu items
            openToolStripMenuItem.Enabled = false;
            viewToolStripMenuItem.Enabled = false;
        }

        private void btnDisplayStudents_Click(object sender, EventArgs e)
         {
             listAllStudents.Text = ""; //free up the list box/ empty it before printing
             foreach (Student s in StudentsList)
             {
                 listAllStudents.Text = listAllStudents.Text + s.ToString() + " - " + s.getId() + "\r\n"; //list the names and the ids nicely into the list box
             }
         }

         private void btnDisplayOffer_Click(object sender, EventArgs e)
         {
             ListAllPapers.Text = ""; //free up the list box/ empty it before printing
            foreach (Paper s in PaperList)
            {
                ListAllPapers.Text = ListAllPapers.Text + s.ToString() + " - " + s.getpapername() + "\r\n"; //list the names and the ids nicely into the list box
            }
         }

         private void newPaperToolStripMenuItem_Click(object sender, EventArgs e)
         {
             AddPaper AddPaperForm = new AddPaper(); //making a new form to add paper
             AddPaperForm.ShowDialog(); // give priority to this form while its active and freeze the parent form to avoid errors
         }

         private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
         {
             this.Close(); //exit the application :D
         }

         private void newStudentToolStripMenuItem_Click(object sender, EventArgs e)
         {
             AddStudent AddStudentForm = new AddStudent(); //makeing a new form to add students to the system
             AddStudentForm.ShowDialog(); //same as adding paper pretty much //error validation
         }

         private void studentToAPaperToolStripMenuItem_Click(object sender, EventArgs e)
         {
             Enrol EnrolForm = new Enrol(); //new form for enrolling
             EnrolForm.ShowDialog(); //opening with error validation
         }

         private void helpToolStripMenuItem_Click(object sender, EventArgs e)
         {
             Help helpForm = new Help(); //EASTER EGG HEUEUEHUE :D
             helpForm.Show();
         }

         private void btnSearchPaper_Click(object sender, EventArgs e)
         {
             if (inputSearchPaper.Text == "") //error validation if nothing entered and tried to search
             {
                 MessageBox.Show("Please enter a value in the text box"); //error
             }
             string EnrolledPaper = ""; //free up the and empty it before printing before using it
             string ComparePaper = ""; //free up the and empty it before printing before using it
             EnrolledPaper = inputSearchPaper.Text;
             int count = 0;
             foreach (EnrollStudents EC in EnrolledStudentsList)
             {
                 ComparePaper = EC.ToString();
                 List<string> paper = new List<string>(ComparePaper.Split(' ', '-')); //splits the paper and the paper id to make the searh functionality works
                 string firstvalue = paper[0];
                 string secondvalue = paper[3];

                 if (EnrolledPaper == firstvalue)
                 {
                     if (count == 0)
                     {
                         outputSearchPaper.Text = "Students enrolled in " + secondvalue + ":\r\n"; //printing them nicely
                         count++;
                     }
                     outputSearchPaper.Text += EC.printout() + "\r\n";
                 }
             }
         }

         private void btnSearchStudent_Click(object sender, EventArgs e)
         {
             if (inputSearchStudent.Text == "") //error checking
             {
                 MessageBox.Show("Please enter a value in the text box"); //error
             }
             string StudentInPaper = ""; //free up and  empty it before printing to it
             string ComparePaper = ""; //free up and empty it before printing to it
             StudentInPaper = inputSearchStudent.Text;
             int count = 0;
             foreach (EnrollPapers EC in EnrolledPapersList)
             {
                 ComparePaper = EC.ToString();
                 List<string> paper = new List<string>(ComparePaper.Split(' ', '-')); //splitter same as above one
                 string Student = paper[0];
                 string Paper = paper[3];
                 if (StudentInPaper == Student)
                 {
                     if (count == 0)
                     {
                         outputSearchStudent.Text = Student + " is enrolled in:\r\n"; //printing nicely
                         count++;
                     }
                     outputSearchStudent.Text += EC.printout() + "\r\n";
                 }
             }
         }
             
    }
}
