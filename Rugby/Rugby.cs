using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rugby
{
    public partial class Rugby : Form
    {
        public Rugby()
        {
            InitializeComponent();
        }
        //a function to display the scoring into the stats box
        public void txtDisplay(string teamm, string typee, string timee, string playerr)
        {
            statsBox.Text += teamm + " scored a " + typee + " at: " + timee + " by " + playerr + "\r\n";
        }
        //a function to check for the if the user selected a player or not
        public void checking(string teamNZ, string teamAU, string teamEN)
        {
            if (teamNZ == "" && teamAU == "" && teamEN == "")
            {
                MessageBox.Show("Please select a player first~~~~~");
            }
        }
        //a function to enable start button for the user when its should be enabled
        public void enablingstart()
        {
            if (team1selected == true && team2selected == true) { bothTeamsSelected = true; }
            if (bothTeamsSelected == true) { startBtn.Enabled = true; }
        }
        //my global integers declaration
        int min = 0, sec = 0, team1Score = 0, team2Score = 0, tries1 = 0, tries2=0, cons1=0, cons2=0, pens1=0, pens2=0, drops1=0, drops2=0;
        bool team1selected = false;
        bool team2selected = false;
        bool bothTeamsSelected = false;
        string strTeam1 = "", strTeam2 = ""; //strings hold the names of the teams in the current session
        private void timer1_Tick(object sender, EventArgs e)
        {
            //the timer algorithm
            timerTxt.Text = min.ToString("00") + ":" + sec.ToString("00");
            sec++;
            if (sec > 60)
            {
                min++;
                sec = 00;
            }
        }

        private void nzTeam1_CheckedChanged(object sender, EventArgs e)
        {
           //when nz selected in team 1 group
           //the nz flag will appear
            teamFlag1.Image = Properties.Resources.nzd;
            nzTeam2.Enabled = false; //the nz in the team 2 group will fade out so the user wont be able to choose same team
            egTeam2.Enabled = true;
            auTeam2.Enabled = true;
            nzPlayers1.Visible = true; //a drop down list of the players will appear depending on what team is being selected
            auPlayers1.Visible = false;
            egPlayers1.Visible = false;
            team1selected = true;
            enablingstart();
            strTeam1 = "NZL";
        }

        private void nzTeam2_CheckedChanged(object sender, EventArgs e)
        { 
            //when nz is selected on the team 2 group
            //everything is the same but inversed to the above event
            teamFlag2.Image = Properties.Resources.nzd;
            nzTeam1.Enabled = false;
            egTeam1.Enabled = true;
            auTeam1.Enabled = true;
            nzPlayers2.Visible = true;
            auPlayers2.Visible = false;
            egPlayers2.Visible = false;
            team2selected = true;
            enablingstart();
            strTeam2 = "NZL";
        }

        private void egTeam1_CheckedChanged(object sender, EventArgs e)
        {
            //this event get activated when the user choose england team in the first group
            //very similar to what happened previously
            teamFlag1.Image = Properties.Resources.eng;
            nzTeam2.Enabled = true;
            egTeam2.Enabled = false;
            auTeam2.Enabled = true;
            egPlayers1.Visible = true;
            auPlayers1.Visible = false;
            nzPlayers1.Visible = false;
            team1selected = true;
            enablingstart();
            strTeam1 = "ENG";
        }

        private void egTeam2_CheckedChanged(object sender, EventArgs e)
        {
            //this event get activated when the user choose england team in the second group
            //very similar to what happened previously
            teamFlag2.Image = Properties.Resources.eng;
            nzTeam1.Enabled = true;
            egTeam1.Enabled = false;
            auTeam1.Enabled = true;
            egPlayers2.Visible = true;
            auPlayers2.Visible = false;
            nzPlayers2.Visible = false;
            team2selected = true;
            enablingstart();
            strTeam2 = "ENG";
        }

        private void auTeam1_CheckedChanged(object sender, EventArgs e)
        {
            //this event get activated when the user choose australia team in the first group
            //very similar to what happened previously
            teamFlag1.Image = Properties.Resources.aus;
            nzTeam2.Enabled = true;
            egTeam2.Enabled = true;
            auTeam2.Enabled = false;
            auPlayers1.Visible = true;
            egPlayers1.Visible = false;
            nzPlayers1.Visible = false;
            team1selected = true;
            enablingstart();
            strTeam1 = "AUS";
        }

        private void auTeam2_CheckedChanged(object sender, EventArgs e)
        {
            //this event get activated when the user choose england team in the second group
            //very similar to what happened previously
            teamFlag2.Image = Properties.Resources.aus;
            nzTeam1.Enabled = true;
            egTeam1.Enabled = true;
            auTeam1.Enabled = false;
            auPlayers2.Visible = true;
            egPlayers2.Visible = false;
            nzPlayers2.Visible = false;
            team2selected = true;
            enablingstart();
            strTeam2 = "AUS";
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            //the start button event will trigger:
            timer1.Start(); //the clock
            tryBtn1.Enabled = true; //activate all the buttons
            conBtn1.Enabled = true;
            penBtn1.Enabled = true;
            dropBtn1.Enabled = true;
            tryBtn2.Enabled = true;
            conBtn2.Enabled = true;
            penBtn2.Enabled = true;
            dropBtn2.Enabled = true;
            pauseBtn.Enabled = true;
            endBtn.Enabled = true;
            resetBtn.Enabled = false;
            nzTeam1.Enabled = false;
            nzTeam2.Enabled = false;
            egTeam1.Enabled = false;
            egTeam2.Enabled = false;
            auTeam1.Enabled = false;
            auTeam2.Enabled = false;
            startBtn.Enabled = false;
        }

        private void endBtn_Click(object sender, EventArgs e)
        {
            timer1.Stop(); //end button stops the  timer  and hides everyhing else
            tryBtn1.Enabled = false;
            conBtn1.Enabled = false;
            penBtn1.Enabled = false;
            dropBtn1.Enabled = false;
            tryBtn2.Enabled = false;
            conBtn2.Enabled = false;
            penBtn2.Enabled = false;
            dropBtn2.Enabled = false;
            resetBtn.Enabled = true;
            pauseBtn.Enabled = false;
            startBtn.Enabled = false;
            endBtn.Enabled = false; //the match stats also get generated here in this event
            statsBox.Text += "=== MATCH STATS ===\r\n";
            if (team1Score > team2Score) //if the first team win
            {
                statsBox.Text += "WINNER is: " + strTeam1 + " \r\n";
                statsBox.Text += strTeam1 + " stats: \r\n";
                if (tries1 > 0) { statsBox.Text += "Tries: " + tries1 + "\r\n"; }
                if (cons1 > 0) { statsBox.Text += "Conversions: " + cons1 + "\r\n"; }
                if (pens1 > 0) { statsBox.Text += "Penalties: " + pens1 + "\r\n"; }
                if (drops1 > 0) { statsBox.Text += "Drop Kicks: " + drops1 + "\r\n"; }
                statsBox.Text += strTeam2 + " stats: \r\n";
                if (tries2 > 0) { statsBox.Text += "Tries: " + tries2 + "\r\n"; }
                if (cons2 > 0) { statsBox.Text += "Conversions: " + cons2 + "\r\n"; }
                if (pens2 > 0) { statsBox.Text += "Penalties: " + pens2 + "\r\n"; }
                if (drops2 > 0) { statsBox.Text += "Drop Kicks: " + drops2 + "\r\n"; }
            }
            if (team1Score < team2Score) //if the second team win
            {
                statsBox.Text += "WINNER is: " + strTeam2 + " \r\n";
                statsBox.Text += strTeam2 + " stats: \r\n";
                if (tries2 > 0) { statsBox.Text += "Tries: " + tries2 + "\r\n"; }
                if (cons2 > 0) { statsBox.Text += "Conversions: " + cons2 + "\r\n"; }
                if (pens2 > 0) { statsBox.Text += "Penalties: " + pens2 + "\r\n"; }
                if (drops2 > 0) { statsBox.Text += "Drop Kicks: " + drops2 + "\r\n"; }
                statsBox.Text += strTeam1 + " stats: \r\n";
                if (tries1 > 0) { statsBox.Text += "Tries: " + tries1 + "\r\n"; }
                if (cons1 > 0) { statsBox.Text += "Conversions: " + cons1 + "\r\n"; }
                if (pens1 > 0) { statsBox.Text += "Penalties: " + pens1 + "\r\n"; }
                if (drops1 > 0) { statsBox.Text += "Drop Kicks: " + drops1 + "\r\n"; }
            }
            if (team1Score == team2Score) //if both teams are draw
            {
                statsBox.Text +=  " ITS A DRAW!\r\n";
                statsBox.Text += strTeam1 + " stats: \r\n";
                if (tries1 > 0) { statsBox.Text += "Tries: " + tries1 + "\r\n"; }
                if (cons1 > 0) { statsBox.Text += "Conversions: " + cons1 + "\r\n"; }
                if (pens1 > 0) { statsBox.Text += "Penalties: " + pens1 + "\r\n"; }
                if (drops1 > 0) { statsBox.Text += "Drop Kicks: " + drops1 + "\r\n"; }
                statsBox.Text += strTeam2 + " stats: \r\n";
                if (tries2 > 0) { statsBox.Text += "Tries: " + tries2 + "\r\n"; }
                if (cons2 > 0) { statsBox.Text += "Conversions: " + cons2 + "\r\n"; }
                if (pens2 > 0) { statsBox.Text += "Penalties: " + pens2 + "\r\n"; }
                if (drops2 > 0) { statsBox.Text += "Drop Kicks: " + drops2 + "\r\n"; }
            }

        }
        private void resetBtn_Click(object sender, EventArgs e)
        {
            //resets everything back to the launch original values, including
            min = 0; //reseting the clock values
            sec = 0;
            team1Score = 0; //the teams scores
            team2Score = 0;
            teamScore1.Text = 0.ToString();
            teamScore2.Text = 0.ToString();
            timerTxt.Text = "00:00";
            egTeam1.Checked = false; //unchecks the bullet points
            egTeam2.Checked = false;
            nzTeam1.Checked = false;
            nzTeam2.Checked = false;
            auTeam1.Checked = false;
            auTeam2.Checked = false;
            nzTeam1.Enabled = true; //enable all bullet points
            nzTeam2.Enabled = true;
            egTeam1.Enabled = true;
            egTeam2.Enabled = true;
            auTeam1.Enabled = true;
            auTeam2.Enabled = true;
            teamFlag1.Image = Properties.Resources.nullimg; //reset the images back to null image
            teamFlag2.Image = Properties.Resources.nullimg;
            tryBtn1.Enabled = false; //disable all the buttons
            conBtn1.Enabled = false;
            penBtn1.Enabled = false;
            dropBtn1.Enabled = false;
            tryBtn2.Enabled = false;
            conBtn2.Enabled = false;
            penBtn2.Enabled = false;
            dropBtn2.Enabled = false;
            startBtn.Enabled = false;
            endBtn.Enabled = false;
            nzPlayers1.Text = null; //reset the players drop down lists to null
            nzPlayers2.Text = null;
            egPlayers1.Text = null;
            egPlayers2.Text = null;
            auPlayers1.Text = null;
            auPlayers2.Text = null; 
            auPlayers1.Visible = false; //hides the players drop down lists
            auPlayers2.Visible = false;
            egPlayers1.Visible = false;
            egPlayers2.Visible = false;
            nzPlayers1.Visible = false;
            nzPlayers2.Visible = false;
            strTeam1 = ""; //reset the strings to empty
            strTeam2 = "";
            statsBox.Text = ""; //resets the stats box to empty
            tries1=0; //all the integers back to zero
            tries2=0;
            cons1=0;
            cons2=0;
            pens1=0;
            pens2=0;
            drops1=0;
            drops2=0;
            team1selected = false;
            team2selected = false;
            bothTeamsSelected = false;
        }

        private void tryBtn1_Click(object sender, EventArgs e)
        { 
            checking(nzPlayers1.Text, auPlayers1.Text, egPlayers1.Text); //calls the checking function to check player is selected first
            if ((nzPlayers1.Text == "" && egPlayers1.Text == "" && auPlayers1.Text == "") != true) { //blocks the scores from getting recorded unless player is actually chosen
                tries1++;
                team1Score = team1Score + 5;
                String display = Convert.ToString(team1Score);
                teamScore1.Text = display; 
            }
            string type  = "try";
            if (nzPlayers1.Text != "")
            {
                txtDisplay(strTeam1, type, timerTxt.Text, nzPlayers1.Text);
            }
            else if (auPlayers1.Text != "")
            {
                txtDisplay(strTeam1, type, timerTxt.Text, auPlayers1.Text);
            }
            else if (egPlayers1.Text != "")
            {
                txtDisplay(strTeam1, type, timerTxt.Text, egPlayers1.Text);
            }
        }

        private void tryBtn2_Click(object sender, EventArgs e)
        { //same thing as last event except its for the team 2 try 
            checking(nzPlayers2.Text, auPlayers2.Text, egPlayers2.Text);
            if ((nzPlayers2.Text == "" && egPlayers2.Text == "" && auPlayers2.Text == "") != true) {
                tries2++;
                team2Score = team2Score + 5;
                String display = Convert.ToString(team2Score);
                teamScore2.Text = display; 
            }
            string type = "try";
            if (nzPlayers2.Text != "")
            {
                txtDisplay(strTeam2, type, timerTxt.Text, nzPlayers2.Text);
            }
            else if (auPlayers2.Text != "")
            {
                txtDisplay(strTeam2, type, timerTxt.Text, auPlayers2.Text);
            }
            else if (egPlayers2.Text != "")
            {
                txtDisplay(strTeam2, type, timerTxt.Text, egPlayers2.Text);
            }
        }

        private void conBtn1_Click(object sender, EventArgs e)
        { //same thing again, but this time for conversion
            checking(nzPlayers1.Text, auPlayers1.Text, egPlayers1.Text);
            if ((nzPlayers1.Text == "" && egPlayers1.Text == "" && auPlayers1.Text == "") != true) { 
                cons1++;
                team1Score = team1Score + 2;
                String display = Convert.ToString(team1Score);
                teamScore1.Text = display;
            }
            string type = "conversion";
            if (nzPlayers1.Text != "")
            {
                txtDisplay(strTeam1, type, timerTxt.Text, nzPlayers1.Text);
            }
            else if (auPlayers1.Text != "")
            {
                txtDisplay(strTeam1, type, timerTxt.Text, auPlayers1.Text);
            }
            else if (egPlayers1.Text != "")
            {
                txtDisplay(strTeam1, type, timerTxt.Text, egPlayers1.Text);
            }
        }

        private void conBtn2_Click(object sender, EventArgs e)
        { //exactly same thing but for conversion event on the seoncd taem
            checking(nzPlayers2.Text, auPlayers2.Text, egPlayers2.Text);
            if ((nzPlayers2.Text == "" && egPlayers2.Text == "" && auPlayers2.Text == "") != true) { 
                cons2++;
                team2Score = team2Score + 2;
                String display = Convert.ToString(team2Score);
                teamScore2.Text = display;
            }
            string type = "conversion";
            if (nzPlayers2.Text != "")
            {
                txtDisplay(strTeam2, type, timerTxt.Text.ToString(), nzPlayers2.Text.ToString());
            }
            else if (auPlayers2.Text != "")
            {
                txtDisplay(strTeam2, type, timerTxt.Text, auPlayers2.Text);
            }
            else if (egPlayers2.Text != "")
            {
                txtDisplay(strTeam2, type, timerTxt.Text, egPlayers2.Text);
            }
        }

        private void penBtn1_Click(object sender, EventArgs e)
        { //penalty event for team 1
            checking(nzPlayers1.Text, auPlayers1.Text, egPlayers1.Text);
            if ((nzPlayers1.Text == "" && egPlayers1.Text == "" && auPlayers1.Text == "") != true) { 
                pens1++;
                team1Score = team1Score + 3;
                String display = Convert.ToString(team1Score);
                teamScore1.Text = display;
            }
            string type = "penalty";
            if (nzPlayers1.Text != "")
            {
                txtDisplay(strTeam1, type, timerTxt.Text, nzPlayers1.Text);
            }
            else if (auPlayers1.Text != "")
            {
                txtDisplay(strTeam1, type, timerTxt.Text, auPlayers1.Text);
            }
            else if (egPlayers1.Text != "")
            {
                txtDisplay(strTeam1, type, timerTxt.Text, egPlayers1.Text);
            }
        }

        private void penBtn2_Click(object sender, EventArgs e)
        { //penalty event for second team
            checking(nzPlayers2.Text, auPlayers2.Text, egPlayers2.Text);
            if ((nzPlayers2.Text == "" && egPlayers2.Text == "" && auPlayers2.Text == "") != true) {
                pens2++; 
                team2Score = team2Score + 3;
                String display = Convert.ToString(team2Score);
                teamScore2.Text = display;
            }
            string type = "penalty";
            if (nzPlayers2.Text != "")
            {
                txtDisplay(strTeam2, type, timerTxt.Text, nzPlayers2.Text);
            }
            else if (auPlayers2.Text != "")
            {
                txtDisplay(strTeam2, type, timerTxt.Text, auPlayers2.Text);
            }
            else if (egPlayers2.Text != "")
            {
                txtDisplay(strTeam2, type, timerTxt.Text, egPlayers2.Text);
            }
        }
        private void dropBtn1_Click(object sender, EventArgs e)
        { //drop kick event for team 1
            checking(nzPlayers1.Text, auPlayers1.Text, egPlayers1.Text);
            if ((nzPlayers1.Text == "" && egPlayers1.Text == "" && auPlayers1.Text == "") != true)
            {
                drops1++;
                team1Score = team1Score + 3;
                String display = Convert.ToString(team1Score);
                teamScore1.Text = display;
            }
            string type = "drop kick";
            if (nzPlayers1.Text != "")
            {
                txtDisplay(strTeam1, type, timerTxt.Text, nzPlayers1.Text);
            }
            else if (auPlayers1.Text != "")
            {
                txtDisplay(strTeam1, type, timerTxt.Text, auPlayers1.Text);
            }
            else if (egPlayers1.Text != "")
            {
                txtDisplay(strTeam1, type, timerTxt.Text, egPlayers1.Text);
            }
        }

        private void dropBtn2_Click(object sender, EventArgs e)
        { //drop kicks for team 2
            checking(nzPlayers2.Text, auPlayers2.Text, egPlayers2.Text);
            if ((nzPlayers2.Text == "" && egPlayers2.Text == "" && auPlayers2.Text == "") != true)
            {
                drops2++;
                team2Score = team2Score + 3;
                String display = Convert.ToString(team2Score);
                teamScore2.Text = display;
            }
            string type = "drop kick";
            if (nzPlayers2.Text != "")
            {
                txtDisplay(strTeam2, type, timerTxt.Text, nzPlayers2.Text);
            }
            else if (auPlayers2.Text != "")
            {
                txtDisplay(strTeam2, type, timerTxt.Text, auPlayers2.Text);
            }
            else if (egPlayers2.Text != "")
            {
                txtDisplay(strTeam2, type, timerTxt.Text, egPlayers2.Text);
            }
        }

        private void Rugby_Load(object sender, EventArgs e)
        { //configurations to set the buttons on the launch
            tryBtn1.Enabled = false;
            conBtn1.Enabled = false;
            penBtn1.Enabled = false;
            dropBtn1.Enabled = false;
            tryBtn2.Enabled = false;
            conBtn2.Enabled = false;
            penBtn2.Enabled = false;
            dropBtn2.Enabled = false;
            pauseBtn.Enabled = false;
            endBtn.Enabled = false;
            resetBtn.Enabled = true;
            startBtn.Enabled = false;
            auPlayers1.Visible = false;
            auPlayers2.Visible = false;
            egPlayers1.Visible = false;
            egPlayers2.Visible = false;
            nzPlayers1.Visible = false;
            nzPlayers2.Visible = false;
        }

        private void pauseBtn_Click(object sender, EventArgs e)
        {
            //pause button dis-allow the user from doing certain things
            timer1.Stop();
            pauseBtn.Enabled = false;
            startBtn.Enabled = true;
            tryBtn1.Enabled = false;
            conBtn1.Enabled = false;
            penBtn1.Enabled = false;
            dropBtn1.Enabled = false;
            tryBtn2.Enabled = false;
            conBtn2.Enabled = false;
            penBtn2.Enabled = false;
            dropBtn2.Enabled = false;
        }
    }
}
