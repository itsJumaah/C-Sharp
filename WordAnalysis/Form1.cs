using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace WordAnalysis
{
    public partial class wordAnalysis : Form
    {
 
        public wordAnalysis()
        {
            InitializeComponent();
        }

        Dictionary<string, int> data = new Dictionary<string, int>();   //defining a dictionary to store all the file data in it :D
        
        private void Reader(string file, Dictionary<string, int> data)  //self function to read in the data into a dictionary
        {
            
            string fileText;
            fileText = File.ReadAllText(file);
            fileText = fileText.ToLower();
            var fileContent = fileText;
            var wordEx = new Regex(@"\w+");                              //regular expression to cut the words whenever there a weird charcter
            
            foreach (Match match in wordEx.Matches(fileContent))
            {
                int wordCount = 0;
                data.TryGetValue(match.Value, out wordCount);
                wordCount++;
                data[match.Value] = wordCount;

            }
            
        }

        public void Common()                                              //self function to find the most common words and display them into their box
        {
            int comm = 0;
            string common = "";
            foreach (KeyValuePair<string, int> pair in data)
            {
                if (comm < pair.Value)
                {
                    comm = pair.Value;
                    common = pair.Key;
                }
                
            }
            boxMostCommon.Text = "Frequency: " + comm + " times.\r\n";
            foreach (KeyValuePair<string, int> pair in data)
            {
                if (comm == pair.Value)
                {
                    boxMostCommon.Text += pair.Key + ", ";
                }
            }
        }

        public void Long()                                              //self function to find the longest word and display them into their box
        {
            int len = 0;
            string length = "";
            boxLongest.Text = "";
            foreach (KeyValuePair<string, int> pair in data)
            {
                if (len < pair.Key.Length)
                {
                    len = pair.Key.Length;
                    length = pair.Key;
                }
            }
            boxLongest.Text += "Longest: " + len.ToString() + " letter(s).\r\n";
            foreach (KeyValuePair<string, int> pair in data)
            {
                if (len == pair.Key.Length)
                {
                    boxLongest.Text += pair.Key + ", ";
                }
            }
        }

        public void Short()                                              //self function to find the shortest word and display them into their box
        {
            int len = 100;
            string length = "";
            boxShortest.Text = "";
            foreach (KeyValuePair<string, int> pair in data)
            {
                if (len > pair.Key.Length)
                {
                    len = pair.Key.Length;
                    length = pair.Key;
                }
            }
            boxShortest.Text += "Shortest: " + len.ToString() + " letter(s).\r\n";
            foreach (KeyValuePair<string, int> pair in data)
            {
                if (len == pair.Key.Length)
                {
                    boxShortest.Text += pair.Key + ", ";
                }
            }
        }

        public void Average()                                              //self function to find the average of the words length and display them into their box
        {
            float num = 0, charNum = 0, ave = 0;
            foreach (KeyValuePair<string, int> pair in data)
            {
                num++;
                charNum += pair.Key.Length;
            }
            ave = charNum / num;
            boxAverage.Text = ave.ToString(".00");
            lablAveNo.Text = boxAverage.Text;
            lablAbsNo.Text = num.ToString();

        }

        public void Unique()                                              //self function to find the unique words and display them into their box
        {
            string word = "";
            boxList.Text = "";
            foreach (KeyValuePair<string, int> pair in data)
            {
                word = pair.Key;
                boxList.Text += word + " ";
            }
        }

        public void ShowChart()                                              //self function to load in the chart with data and display them
        {

            foreach (KeyValuePair<string, int> pair in data)
            {
                this.chart.Series["Words"].Points.AddXY(pair.Key, pair.Value);
                chart.ChartAreas[0].AxisX.LabelStyle.Angle = -90;
                chart.ChartAreas[0].AxisX.Interval = 1;
                chart.ChartAreas[0].AxisX.LabelAutoFitMinFontSize = 5;
                chart.ChartAreas[0].AxisX.Maximum = 25;
            }
        }

        private void wordAnalysis_Load(object sender, EventArgs e)
        {
            ResetValues();                                                         //calling reset values function on app load
        }

        private void ResetValues()                                              //self function to reset all the values the dafault which is empty and that :D
        {
            data.Clear();                                                               // clears the dictionary

            foreach (var series in chart.Series)                             //clears the chart
            {
                series.Points.Clear();
            }

            btnSearchWord.Enabled = false;
            btnSearchLength.Enabled = false;
            srchWordInput.Enabled = false;
            srchLenghtInput.Enabled = false;

            boxMostCommon.Text = "";
            boxLongest.Text = "";
            boxShortest.Text = "";
            boxAverage.Text = "";
            srchWordInput.Text = "";
            srchLenghtInput.Text = "";
            srchWordOutput.Text = "";
            srchLengthOutput.Text = "";
            boxList.Text = "";

            lablFilename.Text = "File";
            lablAveNo.Text = "";
            lablAbsNo.Text = "";

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            ResetValues();                          //reset happens before loadin in a new file
            OpenFileDialog browse = new OpenFileDialog();
            browse.Title = "Open a text file";                                  //title of the browse window
            browse.Filter = "Text File|*.txt";                                       //only allow .txt ext
            browse.InitialDirectory = @"C:\";                                                   //initial dir
            if (browse.ShowDialog() == DialogResult.OK && File.ReadAllText(browse.FileName) != "")
            {
                MessageBox.Show("Congratulations you have loaded the only thing possible to load correctly :P\n" + browse.FileName.ToString());
                lablFilename.Text = browse.FileName;                                         //copy the file name into the label
                
                btnSearchWord.Enabled = true;
                btnSearchLength.Enabled = true;
                srchWordInput.Enabled = true;
                srchLenghtInput.Enabled = true;

                Reader(browse.FileName, data);


                browse.AddExtension = true;                                             //warning if a user types the name of a file but doesn't specify the extension
                browse.CheckFileExists = true;                                           // warning if a user types the name of a file that does not exist
                browse.CheckPathExists = true;                                   // warning if a user types the path of a file that does not exist
                browse.ShowHelp = true;                                                     //a Help button on the dialog

                Common();                                                           //excuting the functions
                Long();
                Short();
                Average();
                Unique();
                ShowChart();
                
            }
            else 
            {
                                                                                            //handle error of empty files and canceling the open new file
            }
        }

        private void btnSearchWord_Click(object sender, EventArgs e)                         //**SEARCH WORD CLICK
        {
            srchWordOutput.Text = "";
            foreach (KeyValuePair<string, int> pair in data) 
            {
                if (srchWordInput.Text == pair.Key)
                {
                    srchWordOutput.Text ="Number of occurrences: " + pair.Value.ToString();
                }
            }
        }

        private void btnSearchLength_Click(object sender, EventArgs e)                         //**SEARCH LENGTH CLICK
        {
            srchLengthOutput.Text = "";
            foreach (KeyValuePair<string, int> pair in data)
            {
                if (srchLenghtInput.Text == "") { }
                else
                {
                    int wordLen = Convert.ToInt32(srchLenghtInput.Text);
                    if (wordLen == pair.Key.Length)
                    {
                        srchLengthOutput.Text += pair.Key + ", ";
                    }
                }
            }
        }

        private void srchWordInput_KeyPress(object sender, KeyPressEventArgs e)                         //**INPUT VALIDATION**
        {
            if (!Char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                base.OnKeyPress(e);
            }
        }

        private void srchLengthInput_KeyPress(object sender, KeyPressEventArgs e)                         //**INPUT VALIDATION**
        {
            if (!Char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                base.OnKeyPress(e);
            }
        }
    }
}
