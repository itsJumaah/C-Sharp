namespace StudentManagementSystemGUI
{
    partial class AddStudent
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
            this.btnCancelStudent = new System.Windows.Forms.Button();
            this.btnSaveStudent = new System.Windows.Forms.Button();
            this.lablStudentId = new System.Windows.Forms.Label();
            this.labStudentDob = new System.Windows.Forms.Label();
            this.labStudentName = new System.Windows.Forms.Label();
            this.StudentId = new System.Windows.Forms.TextBox();
            this.StudentName = new System.Windows.Forms.TextBox();
            this.labStudentAddress = new System.Windows.Forms.Label();
            this.StudentAddress = new System.Windows.Forms.TextBox();
            this.StudentDOB = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btnCancelStudent
            // 
            this.btnCancelStudent.Location = new System.Drawing.Point(187, 164);
            this.btnCancelStudent.Name = "btnCancelStudent";
            this.btnCancelStudent.Size = new System.Drawing.Size(75, 23);
            this.btnCancelStudent.TabIndex = 15;
            this.btnCancelStudent.Text = "Cancel";
            this.btnCancelStudent.UseVisualStyleBackColor = true;
            this.btnCancelStudent.Click += new System.EventHandler(this.btnCancelStudent_Click);
            // 
            // btnSaveStudent
            // 
            this.btnSaveStudent.Location = new System.Drawing.Point(21, 164);
            this.btnSaveStudent.Name = "btnSaveStudent";
            this.btnSaveStudent.Size = new System.Drawing.Size(75, 23);
            this.btnSaveStudent.TabIndex = 14;
            this.btnSaveStudent.Text = "Save";
            this.btnSaveStudent.UseVisualStyleBackColor = true;
            this.btnSaveStudent.Click += new System.EventHandler(this.btnSaveStudent_Click);
            // 
            // lablStudentId
            // 
            this.lablStudentId.AutoSize = true;
            this.lablStudentId.Location = new System.Drawing.Point(18, 80);
            this.lablStudentId.Name = "lablStudentId";
            this.lablStudentId.Size = new System.Drawing.Size(61, 13);
            this.lablStudentId.TabIndex = 13;
            this.lablStudentId.Text = "Student ID:";
            // 
            // labStudentDob
            // 
            this.labStudentDob.AutoSize = true;
            this.labStudentDob.Location = new System.Drawing.Point(18, 50);
            this.labStudentDob.Name = "labStudentDob";
            this.labStudentDob.Size = new System.Drawing.Size(73, 13);
            this.labStudentDob.TabIndex = 12;
            this.labStudentDob.Text = "Student DOB:";
            // 
            // labStudentName
            // 
            this.labStudentName.AutoSize = true;
            this.labStudentName.Location = new System.Drawing.Point(18, 21);
            this.labStudentName.Name = "labStudentName";
            this.labStudentName.Size = new System.Drawing.Size(78, 13);
            this.labStudentName.TabIndex = 11;
            this.labStudentName.Text = "Student Name:";
            // 
            // StudentId
            // 
            this.StudentId.Location = new System.Drawing.Point(137, 73);
            this.StudentId.Name = "StudentId";
            this.StudentId.Size = new System.Drawing.Size(136, 20);
            this.StudentId.TabIndex = 10;
            this.StudentId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StudentId_KeyPress);
            // 
            // StudentName
            // 
            this.StudentName.Location = new System.Drawing.Point(137, 21);
            this.StudentName.Name = "StudentName";
            this.StudentName.Size = new System.Drawing.Size(136, 20);
            this.StudentName.TabIndex = 8;
            this.StudentName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StudentName_KeyPress);
            // 
            // labStudentAddress
            // 
            this.labStudentAddress.AutoSize = true;
            this.labStudentAddress.Location = new System.Drawing.Point(18, 106);
            this.labStudentAddress.Name = "labStudentAddress";
            this.labStudentAddress.Size = new System.Drawing.Size(88, 13);
            this.labStudentAddress.TabIndex = 17;
            this.labStudentAddress.Text = "Student Address:";
            // 
            // StudentAddress
            // 
            this.StudentAddress.Location = new System.Drawing.Point(137, 99);
            this.StudentAddress.Name = "StudentAddress";
            this.StudentAddress.Size = new System.Drawing.Size(136, 20);
            this.StudentAddress.TabIndex = 16;
            // 
            // StudentDOB
            // 
            this.StudentDOB.Location = new System.Drawing.Point(137, 47);
            this.StudentDOB.Mask = "00/00/0000";
            this.StudentDOB.Name = "StudentDOB";
            this.StudentDOB.Size = new System.Drawing.Size(136, 20);
            this.StudentDOB.TabIndex = 18;
            this.StudentDOB.ValidatingType = typeof(System.DateTime);
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 211);
            this.Controls.Add(this.StudentDOB);
            this.Controls.Add(this.labStudentAddress);
            this.Controls.Add(this.StudentAddress);
            this.Controls.Add(this.btnCancelStudent);
            this.Controls.Add(this.btnSaveStudent);
            this.Controls.Add(this.lablStudentId);
            this.Controls.Add(this.labStudentDob);
            this.Controls.Add(this.labStudentName);
            this.Controls.Add(this.StudentId);
            this.Controls.Add(this.StudentName);
            this.Name = "AddStudent";
            this.Text = "AddStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelStudent;
        private System.Windows.Forms.Button btnSaveStudent;
        private System.Windows.Forms.Label lablStudentId;
        private System.Windows.Forms.Label labStudentDob;
        private System.Windows.Forms.Label labStudentName;
        private System.Windows.Forms.TextBox StudentId;
        private System.Windows.Forms.TextBox StudentName;
        private System.Windows.Forms.Label labStudentAddress;
        private System.Windows.Forms.TextBox StudentAddress;
        private System.Windows.Forms.MaskedTextBox StudentDOB;
    }
}