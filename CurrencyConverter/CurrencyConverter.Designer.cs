namespace Assignment2
{
    partial class CurrencyConverterForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.fromNZD = new System.Windows.Forms.Button();
            this.fromAUD = new System.Windows.Forms.Button();
            this.fromEUR = new System.Windows.Forms.Button();
            this.fromCAD = new System.Windows.Forms.Button();
            this.fromGBP = new System.Windows.Forms.Button();
            this.fromUSD = new System.Windows.Forms.Button();
            this.toUSD = new System.Windows.Forms.Button();
            this.toGBP = new System.Windows.Forms.Button();
            this.toCAD = new System.Windows.Forms.Button();
            this.toEUR = new System.Windows.Forms.Button();
            this.toAUD = new System.Windows.Forms.Button();
            this.toNZD = new System.Windows.Forms.Button();
            this.convert = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.finalResult = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.to = new System.Windows.Forms.Label();
            this.from = new System.Windows.Forms.Label();
            this.rowInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rage Italic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Currency Converter";
            // 
            // fromNZD
            // 
            this.fromNZD.Location = new System.Drawing.Point(44, 96);
            this.fromNZD.Name = "fromNZD";
            this.fromNZD.Size = new System.Drawing.Size(75, 23);
            this.fromNZD.TabIndex = 1;
            this.fromNZD.Text = "NZD";
            this.fromNZD.UseVisualStyleBackColor = true;
            this.fromNZD.Click += new System.EventHandler(this.button1_Click);
            // 
            // fromAUD
            // 
            this.fromAUD.Location = new System.Drawing.Point(139, 96);
            this.fromAUD.Name = "fromAUD";
            this.fromAUD.Size = new System.Drawing.Size(75, 23);
            this.fromAUD.TabIndex = 2;
            this.fromAUD.Text = "AUD";
            this.fromAUD.UseVisualStyleBackColor = true;
            this.fromAUD.Click += new System.EventHandler(this.fromAUD_Click);
            // 
            // fromEUR
            // 
            this.fromEUR.Location = new System.Drawing.Point(44, 125);
            this.fromEUR.Name = "fromEUR";
            this.fromEUR.Size = new System.Drawing.Size(75, 23);
            this.fromEUR.TabIndex = 3;
            this.fromEUR.Text = "EUR";
            this.fromEUR.UseVisualStyleBackColor = true;
            this.fromEUR.Click += new System.EventHandler(this.button3_Click);
            // 
            // fromCAD
            // 
            this.fromCAD.Location = new System.Drawing.Point(139, 125);
            this.fromCAD.Name = "fromCAD";
            this.fromCAD.Size = new System.Drawing.Size(75, 23);
            this.fromCAD.TabIndex = 4;
            this.fromCAD.Text = "CAD";
            this.fromCAD.UseVisualStyleBackColor = true;
            this.fromCAD.Click += new System.EventHandler(this.fromCAD_Click);
            // 
            // fromGBP
            // 
            this.fromGBP.Location = new System.Drawing.Point(44, 154);
            this.fromGBP.Name = "fromGBP";
            this.fromGBP.Size = new System.Drawing.Size(75, 23);
            this.fromGBP.TabIndex = 5;
            this.fromGBP.Text = "GBP";
            this.fromGBP.UseVisualStyleBackColor = true;
            this.fromGBP.Click += new System.EventHandler(this.fromGBP_Click);
            // 
            // fromUSD
            // 
            this.fromUSD.Location = new System.Drawing.Point(139, 154);
            this.fromUSD.Name = "fromUSD";
            this.fromUSD.Size = new System.Drawing.Size(75, 23);
            this.fromUSD.TabIndex = 6;
            this.fromUSD.Text = "USD";
            this.fromUSD.UseVisualStyleBackColor = true;
            this.fromUSD.Click += new System.EventHandler(this.fromUSD_Click);
            // 
            // toUSD
            // 
            this.toUSD.Location = new System.Drawing.Point(458, 154);
            this.toUSD.Name = "toUSD";
            this.toUSD.Size = new System.Drawing.Size(75, 23);
            this.toUSD.TabIndex = 12;
            this.toUSD.Text = "USD";
            this.toUSD.UseVisualStyleBackColor = true;
            this.toUSD.Click += new System.EventHandler(this.toUSD_Click);
            // 
            // toGBP
            // 
            this.toGBP.Location = new System.Drawing.Point(363, 154);
            this.toGBP.Name = "toGBP";
            this.toGBP.Size = new System.Drawing.Size(75, 23);
            this.toGBP.TabIndex = 11;
            this.toGBP.Text = "GBP";
            this.toGBP.UseVisualStyleBackColor = true;
            this.toGBP.Click += new System.EventHandler(this.toGBP_Click);
            // 
            // toCAD
            // 
            this.toCAD.Location = new System.Drawing.Point(458, 125);
            this.toCAD.Name = "toCAD";
            this.toCAD.Size = new System.Drawing.Size(75, 23);
            this.toCAD.TabIndex = 10;
            this.toCAD.Text = "CAD";
            this.toCAD.UseVisualStyleBackColor = true;
            this.toCAD.Click += new System.EventHandler(this.toCAD_Click);
            // 
            // toEUR
            // 
            this.toEUR.Location = new System.Drawing.Point(363, 125);
            this.toEUR.Name = "toEUR";
            this.toEUR.Size = new System.Drawing.Size(75, 23);
            this.toEUR.TabIndex = 9;
            this.toEUR.Text = "EUR";
            this.toEUR.UseVisualStyleBackColor = true;
            this.toEUR.Click += new System.EventHandler(this.toEUR_Click);
            // 
            // toAUD
            // 
            this.toAUD.Location = new System.Drawing.Point(458, 96);
            this.toAUD.Name = "toAUD";
            this.toAUD.Size = new System.Drawing.Size(75, 23);
            this.toAUD.TabIndex = 8;
            this.toAUD.Text = "AUD";
            this.toAUD.UseVisualStyleBackColor = true;
            this.toAUD.Click += new System.EventHandler(this.toAUD_Click);
            // 
            // toNZD
            // 
            this.toNZD.Location = new System.Drawing.Point(363, 96);
            this.toNZD.Name = "toNZD";
            this.toNZD.Size = new System.Drawing.Size(75, 23);
            this.toNZD.TabIndex = 7;
            this.toNZD.Text = "NZD";
            this.toNZD.UseVisualStyleBackColor = true;
            this.toNZD.Click += new System.EventHandler(this.toNZD_Click);
            // 
            // convert
            // 
            this.convert.Location = new System.Drawing.Point(139, 268);
            this.convert.Name = "convert";
            this.convert.Size = new System.Drawing.Size(75, 23);
            this.convert.TabIndex = 13;
            this.convert.Text = "Convert!";
            this.convert.UseVisualStyleBackColor = true;
            this.convert.Click += new System.EventHandler(this.convert_Click);
            // 
            // reset
            // 
            this.reset.ForeColor = System.Drawing.SystemColors.Desktop;
            this.reset.Location = new System.Drawing.Point(237, 325);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(95, 23);
            this.reset.TabIndex = 14;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Convert to:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Convert from:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "To:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(181, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "From:";
            // 
            // finalResult
            // 
            this.finalResult.AutoSize = true;
            this.finalResult.Location = new System.Drawing.Point(234, 278);
            this.finalResult.Name = "finalResult";
            this.finalResult.Size = new System.Drawing.Size(55, 13);
            this.finalResult.TabIndex = 19;
            this.finalResult.Text = "________";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(168, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Amount:";
            // 
            // to
            // 
            this.to.AutoSize = true;
            this.to.Location = new System.Drawing.Point(234, 240);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(55, 13);
            this.to.TabIndex = 21;
            this.to.Text = "________";
            // 
            // from
            // 
            this.from.AutoSize = true;
            this.from.Location = new System.Drawing.Point(234, 227);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(55, 13);
            this.from.TabIndex = 22;
            this.from.Text = "________";
            // 
            // rowInput
            // 
            this.rowInput.Location = new System.Drawing.Point(237, 198);
            this.rowInput.Name = "rowInput";
            this.rowInput.Size = new System.Drawing.Size(100, 20);
            this.rowInput.TabIndex = 25;
            this.rowInput.TextChanged += new System.EventHandler(this.rowInput_TextChanged_1);
            this.rowInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rowInput_TextChanged_1);
            // 
            // CurrencyConverterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 369);
            this.Controls.Add(this.rowInput);
            this.Controls.Add(this.from);
            this.Controls.Add(this.to);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.finalResult);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.convert);
            this.Controls.Add(this.toUSD);
            this.Controls.Add(this.toGBP);
            this.Controls.Add(this.toCAD);
            this.Controls.Add(this.toEUR);
            this.Controls.Add(this.toAUD);
            this.Controls.Add(this.toNZD);
            this.Controls.Add(this.fromUSD);
            this.Controls.Add(this.fromGBP);
            this.Controls.Add(this.fromCAD);
            this.Controls.Add(this.fromEUR);
            this.Controls.Add(this.fromAUD);
            this.Controls.Add(this.fromNZD);
            this.Controls.Add(this.label1);
            this.Name = "CurrencyConverterForm";
            this.Text = "Currency Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button fromNZD;
        private System.Windows.Forms.Button fromAUD;
        private System.Windows.Forms.Button fromEUR;
        private System.Windows.Forms.Button fromCAD;
        private System.Windows.Forms.Button fromGBP;
        private System.Windows.Forms.Button fromUSD;
        private System.Windows.Forms.Button toUSD;
        private System.Windows.Forms.Button toGBP;
        private System.Windows.Forms.Button toCAD;
        private System.Windows.Forms.Button toEUR;
        private System.Windows.Forms.Button toAUD;
        private System.Windows.Forms.Button toNZD;
        private System.Windows.Forms.Button convert;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label finalResult;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label to;
        private System.Windows.Forms.Label from;
        private System.Windows.Forms.TextBox rowInput;
    }
}

