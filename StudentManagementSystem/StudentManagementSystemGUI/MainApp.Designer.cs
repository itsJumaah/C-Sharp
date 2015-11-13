namespace StudentManagementSystemGUI
{
    partial class MainApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listAllStudents = new System.Windows.Forms.TextBox();
            this.outputSearchPaper = new System.Windows.Forms.TextBox();
            this.btnDisplayStudents = new System.Windows.Forms.Button();
            this.btnSearchPaper = new System.Windows.Forms.Button();
            this.btnSearchStudent = new System.Windows.Forms.Button();
            this.btnDisplayOffer = new System.Windows.Forms.Button();
            this.ListAllPapers = new System.Windows.Forms.TextBox();
            this.outputSearchStudent = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileText = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPaperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToAPaperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lablLogo = new System.Windows.Forms.Label();
            this.lablListOfAllStudents = new System.Windows.Forms.Label();
            this.lablListStudentsInPaper = new System.Windows.Forms.Label();
            this.lablPaperOffering = new System.Windows.Forms.Label();
            this.lablStudentsPaperSearch = new System.Windows.Forms.Label();
            this.inputSearchPaper = new System.Windows.Forms.TextBox();
            this.inputSearchStudent = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listAllStudents
            // 
            this.listAllStudents.Location = new System.Drawing.Point(40, 140);
            this.listAllStudents.Multiline = true;
            this.listAllStudents.Name = "listAllStudents";
            this.listAllStudents.ReadOnly = true;
            this.listAllStudents.Size = new System.Drawing.Size(178, 307);
            this.listAllStudents.TabIndex = 0;
            // 
            // outputSearchPaper
            // 
            this.outputSearchPaper.Location = new System.Drawing.Point(244, 140);
            this.outputSearchPaper.Multiline = true;
            this.outputSearchPaper.Name = "outputSearchPaper";
            this.outputSearchPaper.ReadOnly = true;
            this.outputSearchPaper.Size = new System.Drawing.Size(178, 307);
            this.outputSearchPaper.TabIndex = 1;
            // 
            // btnDisplayStudents
            // 
            this.btnDisplayStudents.Location = new System.Drawing.Point(40, 453);
            this.btnDisplayStudents.Name = "btnDisplayStudents";
            this.btnDisplayStudents.Size = new System.Drawing.Size(74, 23);
            this.btnDisplayStudents.TabIndex = 4;
            this.btnDisplayStudents.Text = "Display";
            this.btnDisplayStudents.UseMnemonic = false;
            this.btnDisplayStudents.UseVisualStyleBackColor = true;
            this.btnDisplayStudents.Click += new System.EventHandler(this.btnDisplayStudents_Click);
            // 
            // btnSearchPaper
            // 
            this.btnSearchPaper.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchPaper.Location = new System.Drawing.Point(244, 453);
            this.btnSearchPaper.Name = "btnSearchPaper";
            this.btnSearchPaper.Size = new System.Drawing.Size(74, 23);
            this.btnSearchPaper.TabIndex = 5;
            this.btnSearchPaper.Text = "Search";
            this.btnSearchPaper.UseVisualStyleBackColor = true;
            this.btnSearchPaper.Click += new System.EventHandler(this.btnSearchPaper_Click);
            // 
            // btnSearchStudent
            // 
            this.btnSearchStudent.Location = new System.Drawing.Point(653, 453);
            this.btnSearchStudent.Name = "btnSearchStudent";
            this.btnSearchStudent.Size = new System.Drawing.Size(75, 23);
            this.btnSearchStudent.TabIndex = 6;
            this.btnSearchStudent.Text = "Search";
            this.btnSearchStudent.UseVisualStyleBackColor = true;
            this.btnSearchStudent.Click += new System.EventHandler(this.btnSearchStudent_Click);
            // 
            // btnDisplayOffer
            // 
            this.btnDisplayOffer.Location = new System.Drawing.Point(450, 453);
            this.btnDisplayOffer.Name = "btnDisplayOffer";
            this.btnDisplayOffer.Size = new System.Drawing.Size(75, 23);
            this.btnDisplayOffer.TabIndex = 7;
            this.btnDisplayOffer.Text = "Display";
            this.btnDisplayOffer.UseVisualStyleBackColor = true;
            this.btnDisplayOffer.Click += new System.EventHandler(this.btnDisplayOffer_Click);
            // 
            // ListAllPapers
            // 
            this.ListAllPapers.Location = new System.Drawing.Point(450, 140);
            this.ListAllPapers.Multiline = true;
            this.ListAllPapers.Name = "ListAllPapers";
            this.ListAllPapers.ReadOnly = true;
            this.ListAllPapers.Size = new System.Drawing.Size(178, 307);
            this.ListAllPapers.TabIndex = 9;
            // 
            // outputSearchStudent
            // 
            this.outputSearchStudent.Location = new System.Drawing.Point(653, 140);
            this.outputSearchStudent.Multiline = true;
            this.outputSearchStudent.Name = "outputSearchStudent";
            this.outputSearchStudent.ReadOnly = true;
            this.outputSearchStudent.Size = new System.Drawing.Size(178, 307);
            this.outputSearchStudent.TabIndex = 10;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileText,
            this.viewToolStripMenuItem,
            this.windowToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(887, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileText
            // 
            this.fileText.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.fileText.Name = "fileText";
            this.fileText.Size = new System.Drawing.Size(37, 20);
            this.fileText.Text = "File";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPaperToolStripMenuItem,
            this.newStudentToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // newPaperToolStripMenuItem
            // 
            this.newPaperToolStripMenuItem.Name = "newPaperToolStripMenuItem";
            this.newPaperToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.newPaperToolStripMenuItem.Text = "New Paper";
            this.newPaperToolStripMenuItem.Click += new System.EventHandler(this.newPaperToolStripMenuItem_Click);
            // 
            // newStudentToolStripMenuItem
            // 
            this.newStudentToolStripMenuItem.Name = "newStudentToolStripMenuItem";
            this.newStudentToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.newStudentToolStripMenuItem.Text = "New Student";
            this.newStudentToolStripMenuItem.Click += new System.EventHandler(this.newStudentToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentToAPaperToolStripMenuItem});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.exitToolStripMenuItem.Text = "Enroll";
            // 
            // studentToAPaperToolStripMenuItem
            // 
            this.studentToAPaperToolStripMenuItem.Name = "studentToAPaperToolStripMenuItem";
            this.studentToAPaperToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.studentToAPaperToolStripMenuItem.Text = "Student to a paper";
            this.studentToAPaperToolStripMenuItem.Click += new System.EventHandler(this.studentToAPaperToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(104, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // lablLogo
            // 
            this.lablLogo.AutoSize = true;
            this.lablLogo.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablLogo.Location = new System.Drawing.Point(335, 42);
            this.lablLogo.Name = "lablLogo";
            this.lablLogo.Size = new System.Drawing.Size(0, 39);
            this.lablLogo.TabIndex = 12;
            // 
            // lablListOfAllStudents
            // 
            this.lablListOfAllStudents.AutoSize = true;
            this.lablListOfAllStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablListOfAllStudents.Location = new System.Drawing.Point(37, 124);
            this.lablListOfAllStudents.Name = "lablListOfAllStudents";
            this.lablListOfAllStudents.Size = new System.Drawing.Size(112, 13);
            this.lablListOfAllStudents.TabIndex = 13;
            this.lablListOfAllStudents.Text = "List of all the students:";
            // 
            // lablListStudentsInPaper
            // 
            this.lablListStudentsInPaper.AutoSize = true;
            this.lablListStudentsInPaper.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablListStudentsInPaper.Location = new System.Drawing.Point(241, 124);
            this.lablListStudentsInPaper.Name = "lablListStudentsInPaper";
            this.lablListStudentsInPaper.Size = new System.Drawing.Size(187, 13);
            this.lablListStudentsInPaper.TabIndex = 14;
            this.lablListStudentsInPaper.Text = "List all the students enrolled in a paper";
            // 
            // lablPaperOffering
            // 
            this.lablPaperOffering.AutoSize = true;
            this.lablPaperOffering.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablPaperOffering.Location = new System.Drawing.Point(447, 124);
            this.lablPaperOffering.Name = "lablPaperOffering";
            this.lablPaperOffering.Size = new System.Drawing.Size(110, 13);
            this.lablPaperOffering.TabIndex = 15;
            this.lablPaperOffering.Text = "List all offered papers:";
            // 
            // lablStudentsPaperSearch
            // 
            this.lablStudentsPaperSearch.AutoSize = true;
            this.lablStudentsPaperSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablStudentsPaperSearch.Location = new System.Drawing.Point(650, 124);
            this.lablStudentsPaperSearch.Name = "lablStudentsPaperSearch";
            this.lablStudentsPaperSearch.Size = new System.Drawing.Size(160, 13);
            this.lablStudentsPaperSearch.TabIndex = 16;
            this.lablStudentsPaperSearch.Text = "List all papers student enrolled in";
            // 
            // inputSearchPaper
            // 
            this.inputSearchPaper.Location = new System.Drawing.Point(325, 454);
            this.inputSearchPaper.Name = "inputSearchPaper";
            this.inputSearchPaper.Size = new System.Drawing.Size(97, 20);
            this.inputSearchPaper.TabIndex = 17;
            // 
            // inputSearchStudent
            // 
            this.inputSearchStudent.Location = new System.Drawing.Point(734, 453);
            this.inputSearchStudent.Name = "inputSearchStudent";
            this.inputSearchStudent.Size = new System.Drawing.Size(97, 20);
            this.inputSearchStudent.TabIndex = 18;
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 538);
            this.Controls.Add(this.inputSearchStudent);
            this.Controls.Add(this.inputSearchPaper);
            this.Controls.Add(this.lablStudentsPaperSearch);
            this.Controls.Add(this.lablPaperOffering);
            this.Controls.Add(this.lablListStudentsInPaper);
            this.Controls.Add(this.lablListOfAllStudents);
            this.Controls.Add(this.lablLogo);
            this.Controls.Add(this.outputSearchStudent);
            this.Controls.Add(this.ListAllPapers);
            this.Controls.Add(this.btnDisplayOffer);
            this.Controls.Add(this.btnSearchStudent);
            this.Controls.Add(this.btnSearchPaper);
            this.Controls.Add(this.btnDisplayStudents);
            this.Controls.Add(this.outputSearchPaper);
            this.Controls.Add(this.listAllStudents);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainApp";
            this.Text = "Student Management System";
            this.Load += new System.EventHandler(this.MainApp_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox listAllStudents;
        private System.Windows.Forms.TextBox outputSearchPaper;
        private System.Windows.Forms.Button btnDisplayStudents;
        private System.Windows.Forms.Button btnSearchPaper;
        private System.Windows.Forms.Button btnSearchStudent;
        private System.Windows.Forms.Button btnDisplayOffer;
        private System.Windows.Forms.TextBox ListAllPapers;
        private System.Windows.Forms.TextBox outputSearchStudent;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileText;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newPaperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentToAPaperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.Label lablLogo;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label lablListOfAllStudents;
        private System.Windows.Forms.Label lablListStudentsInPaper;
        private System.Windows.Forms.Label lablPaperOffering;
        private System.Windows.Forms.Label lablStudentsPaperSearch;
        private System.Windows.Forms.TextBox inputSearchPaper;
        private System.Windows.Forms.TextBox inputSearchStudent;
    }
}

