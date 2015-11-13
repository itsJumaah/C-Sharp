namespace StudentManagementSystemGUI
{
    partial class AddPaper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPaper));
            this.PaperName = new System.Windows.Forms.TextBox();
            this.PaperNumber = new System.Windows.Forms.TextBox();
            this.PaperCo = new System.Windows.Forms.TextBox();
            this.lablPaperName = new System.Windows.Forms.Label();
            this.lablPaperCode = new System.Windows.Forms.Label();
            this.lablPaperCo = new System.Windows.Forms.Label();
            this.btnSavePaper = new System.Windows.Forms.Button();
            this.btnCancelPaper = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PaperName
            // 
            this.PaperName.Location = new System.Drawing.Point(139, 25);
            this.PaperName.Name = "PaperName";
            this.PaperName.Size = new System.Drawing.Size(136, 20);
            this.PaperName.TabIndex = 0;
            this.PaperName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PaperName_KeyPress);
            // 
            // PaperNumber
            // 
            this.PaperNumber.Location = new System.Drawing.Point(139, 51);
            this.PaperNumber.Name = "PaperNumber";
            this.PaperNumber.Size = new System.Drawing.Size(136, 20);
            this.PaperNumber.TabIndex = 1;
            this.PaperNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PaperNumber_KeyPress);
            // 
            // PaperCo
            // 
            this.PaperCo.Location = new System.Drawing.Point(139, 77);
            this.PaperCo.Name = "PaperCo";
            this.PaperCo.Size = new System.Drawing.Size(136, 20);
            this.PaperCo.TabIndex = 2;
            this.PaperCo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PaperCo_KeyPress);
            // 
            // lablPaperName
            // 
            this.lablPaperName.AutoSize = true;
            this.lablPaperName.Location = new System.Drawing.Point(20, 25);
            this.lablPaperName.Name = "lablPaperName";
            this.lablPaperName.Size = new System.Drawing.Size(69, 13);
            this.lablPaperName.TabIndex = 3;
            this.lablPaperName.Text = "Paper Name:";
            // 
            // lablPaperCode
            // 
            this.lablPaperCode.AutoSize = true;
            this.lablPaperCode.Location = new System.Drawing.Point(20, 54);
            this.lablPaperCode.Name = "lablPaperCode";
            this.lablPaperCode.Size = new System.Drawing.Size(78, 13);
            this.lablPaperCode.TabIndex = 4;
            this.lablPaperCode.Text = "Paper Number:";
            // 
            // lablPaperCo
            // 
            this.lablPaperCo.AutoSize = true;
            this.lablPaperCo.Location = new System.Drawing.Point(20, 84);
            this.lablPaperCo.Name = "lablPaperCo";
            this.lablPaperCo.Size = new System.Drawing.Size(98, 13);
            this.lablPaperCo.TabIndex = 5;
            this.lablPaperCo.Text = "Paper Co-ordinator:";
            // 
            // btnSavePaper
            // 
            this.btnSavePaper.Location = new System.Drawing.Point(23, 125);
            this.btnSavePaper.Name = "btnSavePaper";
            this.btnSavePaper.Size = new System.Drawing.Size(75, 23);
            this.btnSavePaper.TabIndex = 6;
            this.btnSavePaper.Text = "Save";
            this.btnSavePaper.UseVisualStyleBackColor = true;
            this.btnSavePaper.Click += new System.EventHandler(this.btnSavePaper_Click);
            // 
            // btnCancelPaper
            // 
            this.btnCancelPaper.Location = new System.Drawing.Point(189, 125);
            this.btnCancelPaper.Name = "btnCancelPaper";
            this.btnCancelPaper.Size = new System.Drawing.Size(75, 23);
            this.btnCancelPaper.TabIndex = 7;
            this.btnCancelPaper.Text = "Cancel";
            this.btnCancelPaper.UseVisualStyleBackColor = true;
            this.btnCancelPaper.Click += new System.EventHandler(this.btnCancelPaper_Click);
            // 
            // AddPaper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 170);
            this.Controls.Add(this.btnCancelPaper);
            this.Controls.Add(this.btnSavePaper);
            this.Controls.Add(this.lablPaperCo);
            this.Controls.Add(this.lablPaperCode);
            this.Controls.Add(this.lablPaperName);
            this.Controls.Add(this.PaperCo);
            this.Controls.Add(this.PaperNumber);
            this.Controls.Add(this.PaperName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddPaper";
            this.Text = "Add new paper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PaperName;
        private System.Windows.Forms.TextBox PaperNumber;
        private System.Windows.Forms.TextBox PaperCo;
        private System.Windows.Forms.Label lablPaperName;
        private System.Windows.Forms.Label lablPaperCode;
        private System.Windows.Forms.Label lablPaperCo;
        private System.Windows.Forms.Button btnSavePaper;
        private System.Windows.Forms.Button btnCancelPaper;
    }
}