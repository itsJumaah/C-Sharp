namespace WordAnalysis
{
    partial class wordAnalysis
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wordAnalysis));
            this.lablMostCommon = new System.Windows.Forms.Label();
            this.lablShortest = new System.Windows.Forms.Label();
            this.lablAverage = new System.Windows.Forms.Label();
            this.lablSearchWord = new System.Windows.Forms.Label();
            this.lablSearchLength = new System.Windows.Forms.Label();
            this.lablListUnique = new System.Windows.Forms.Label();
            this.lablAbs = new System.Windows.Forms.Label();
            this.lablAve = new System.Windows.Forms.Label();
            this.lablAbsNo = new System.Windows.Forms.Label();
            this.lablLongest = new System.Windows.Forms.Label();
            this.lablAveNo = new System.Windows.Forms.Label();
            this.lablFilename = new System.Windows.Forms.Label();
            this.lablTitle = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.boxMostCommon = new System.Windows.Forms.TextBox();
            this.boxLongest = new System.Windows.Forms.TextBox();
            this.boxShortest = new System.Windows.Forms.TextBox();
            this.boxAverage = new System.Windows.Forms.TextBox();
            this.srchWordInput = new System.Windows.Forms.TextBox();
            this.srchLenghtInput = new System.Windows.Forms.TextBox();
            this.srchWordOutput = new System.Windows.Forms.TextBox();
            this.srchLengthOutput = new System.Windows.Forms.TextBox();
            this.boxList = new System.Windows.Forms.TextBox();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnSearchWord = new System.Windows.Forms.Button();
            this.btnSearchLength = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lablMostCommon
            // 
            this.lablMostCommon.AutoSize = true;
            this.lablMostCommon.Location = new System.Drawing.Point(31, 107);
            this.lablMostCommon.Name = "lablMostCommon";
            this.lablMostCommon.Size = new System.Drawing.Size(104, 13);
            this.lablMostCommon.TabIndex = 0;
            this.lablMostCommon.Text = "Most common words";
            // 
            // lablShortest
            // 
            this.lablShortest.AutoSize = true;
            this.lablShortest.Location = new System.Drawing.Point(31, 267);
            this.lablShortest.Name = "lablShortest";
            this.lablShortest.Size = new System.Drawing.Size(77, 13);
            this.lablShortest.TabIndex = 1;
            this.lablShortest.Text = "Shortest words";
            // 
            // lablAverage
            // 
            this.lablAverage.AutoSize = true;
            this.lablAverage.Location = new System.Drawing.Point(31, 344);
            this.lablAverage.Name = "lablAverage";
            this.lablAverage.Size = new System.Drawing.Size(105, 13);
            this.lablAverage.TabIndex = 2;
            this.lablAverage.Text = "Average word length";
            // 
            // lablSearchWord
            // 
            this.lablSearchWord.AutoSize = true;
            this.lablSearchWord.Location = new System.Drawing.Point(306, 110);
            this.lablSearchWord.Name = "lablSearchWord";
            this.lablSearchWord.Size = new System.Drawing.Size(67, 13);
            this.lablSearchWord.TabIndex = 3;
            this.lablSearchWord.Text = "Search word";
            // 
            // lablSearchLength
            // 
            this.lablSearchLength.AutoSize = true;
            this.lablSearchLength.Location = new System.Drawing.Point(306, 190);
            this.lablSearchLength.Name = "lablSearchLength";
            this.lablSearchLength.Size = new System.Drawing.Size(73, 13);
            this.lablSearchLength.TabIndex = 4;
            this.lablSearchLength.Text = "Search length";
            // 
            // lablListUnique
            // 
            this.lablListUnique.AutoSize = true;
            this.lablListUnique.Location = new System.Drawing.Point(306, 267);
            this.lablListUnique.Name = "lablListUnique";
            this.lablListUnique.Size = new System.Drawing.Size(114, 13);
            this.lablListUnique.TabIndex = 5;
            this.lablListUnique.Text = "List of all unique words";
            // 
            // lablAbs
            // 
            this.lablAbs.AutoSize = true;
            this.lablAbs.Location = new System.Drawing.Point(32, 430);
            this.lablAbs.Name = "lablAbs";
            this.lablAbs.Size = new System.Drawing.Size(261, 13);
            this.lablAbs.TabIndex = 6;
            this.lablAbs.Text = "Absolute number of words (not counting repetitions) is:";
            // 
            // lablAve
            // 
            this.lablAve.AutoSize = true;
            this.lablAve.Location = new System.Drawing.Point(338, 430);
            this.lablAve.Name = "lablAve";
            this.lablAve.Size = new System.Drawing.Size(162, 13);
            this.lablAve.TabIndex = 7;
            this.lablAve.Text = "Average word length all words is:";
            // 
            // lablAbsNo
            // 
            this.lablAbsNo.AutoSize = true;
            this.lablAbsNo.Location = new System.Drawing.Point(298, 430);
            this.lablAbsNo.Name = "lablAbsNo";
            this.lablAbsNo.Size = new System.Drawing.Size(0, 13);
            this.lablAbsNo.TabIndex = 8;
            // 
            // lablLongest
            // 
            this.lablLongest.AutoSize = true;
            this.lablLongest.Location = new System.Drawing.Point(32, 187);
            this.lablLongest.Name = "lablLongest";
            this.lablLongest.Size = new System.Drawing.Size(76, 13);
            this.lablLongest.TabIndex = 9;
            this.lablLongest.Text = "Longest words";
            // 
            // lablAveNo
            // 
            this.lablAveNo.AutoSize = true;
            this.lablAveNo.Location = new System.Drawing.Point(506, 430);
            this.lablAveNo.Name = "lablAveNo";
            this.lablAveNo.Size = new System.Drawing.Size(0, 13);
            this.lablAveNo.TabIndex = 10;
            // 
            // lablFilename
            // 
            this.lablFilename.AutoSize = true;
            this.lablFilename.Location = new System.Drawing.Point(126, 65);
            this.lablFilename.Name = "lablFilename";
            this.lablFilename.Size = new System.Drawing.Size(23, 13);
            this.lablFilename.TabIndex = 11;
            this.lablFilename.Text = "File";
            // 
            // lablTitle
            // 
            this.lablTitle.AutoSize = true;
            this.lablTitle.Font = new System.Drawing.Font("Old English Text MT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablTitle.Location = new System.Drawing.Point(255, 22);
            this.lablTitle.Name = "lablTitle";
            this.lablTitle.Size = new System.Drawing.Size(192, 34);
            this.lablTitle.TabIndex = 12;
            this.lablTitle.Text = "Word Analysis";
            // 
            // picLogo
            // 
            this.picLogo.Image = global::WordAnalysis.Properties.Resources.icon;
            this.picLogo.Location = new System.Drawing.Point(215, 22);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(34, 34);
            this.picLogo.TabIndex = 13;
            this.picLogo.TabStop = false;
            // 
            // boxMostCommon
            // 
            this.boxMostCommon.Location = new System.Drawing.Point(35, 124);
            this.boxMostCommon.Multiline = true;
            this.boxMostCommon.Name = "boxMostCommon";
            this.boxMostCommon.ReadOnly = true;
            this.boxMostCommon.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.boxMostCommon.Size = new System.Drawing.Size(156, 47);
            this.boxMostCommon.TabIndex = 14;
            // 
            // boxLongest
            // 
            this.boxLongest.Location = new System.Drawing.Point(35, 203);
            this.boxLongest.Multiline = true;
            this.boxLongest.Name = "boxLongest";
            this.boxLongest.ReadOnly = true;
            this.boxLongest.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.boxLongest.Size = new System.Drawing.Size(156, 47);
            this.boxLongest.TabIndex = 15;
            // 
            // boxShortest
            // 
            this.boxShortest.Location = new System.Drawing.Point(35, 283);
            this.boxShortest.Multiline = true;
            this.boxShortest.Name = "boxShortest";
            this.boxShortest.ReadOnly = true;
            this.boxShortest.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.boxShortest.Size = new System.Drawing.Size(156, 47);
            this.boxShortest.TabIndex = 16;
            // 
            // boxAverage
            // 
            this.boxAverage.Location = new System.Drawing.Point(34, 360);
            this.boxAverage.Multiline = true;
            this.boxAverage.Name = "boxAverage";
            this.boxAverage.ReadOnly = true;
            this.boxAverage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.boxAverage.Size = new System.Drawing.Size(156, 47);
            this.boxAverage.TabIndex = 17;
            // 
            // srchWordInput
            // 
            this.srchWordInput.Location = new System.Drawing.Point(389, 107);
            this.srchWordInput.Name = "srchWordInput";
            this.srchWordInput.Size = new System.Drawing.Size(111, 20);
            this.srchWordInput.TabIndex = 18;
            this.srchWordInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.srchWordInput_KeyPress);
            // 
            // srchLenghtInput
            // 
            this.srchLenghtInput.Location = new System.Drawing.Point(389, 187);
            this.srchLenghtInput.Name = "srchLenghtInput";
            this.srchLenghtInput.Size = new System.Drawing.Size(111, 20);
            this.srchLenghtInput.TabIndex = 19;
            this.srchLenghtInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.srchLengthInput_KeyPress);
            // 
            // srchWordOutput
            // 
            this.srchWordOutput.Location = new System.Drawing.Point(509, 107);
            this.srchWordOutput.Multiline = true;
            this.srchWordOutput.Name = "srchWordOutput";
            this.srchWordOutput.ReadOnly = true;
            this.srchWordOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.srchWordOutput.Size = new System.Drawing.Size(156, 64);
            this.srchWordOutput.TabIndex = 20;
            // 
            // srchLengthOutput
            // 
            this.srchLengthOutput.Location = new System.Drawing.Point(509, 187);
            this.srchLengthOutput.Multiline = true;
            this.srchLengthOutput.Name = "srchLengthOutput";
            this.srchLengthOutput.ReadOnly = true;
            this.srchLengthOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.srchLengthOutput.Size = new System.Drawing.Size(156, 63);
            this.srchLengthOutput.TabIndex = 21;
            // 
            // boxList
            // 
            this.boxList.Location = new System.Drawing.Point(309, 283);
            this.boxList.Multiline = true;
            this.boxList.Name = "boxList";
            this.boxList.ReadOnly = true;
            this.boxList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.boxList.Size = new System.Drawing.Size(356, 124);
            this.boxList.TabIndex = 22;
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(33, 467);
            this.chart.Name = "chart";
            this.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Navy};
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Words";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(632, 247);
            this.chart.TabIndex = 23;
            this.chart.Text = "Chart";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(35, 60);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 24;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnSearchWord
            // 
            this.btnSearchWord.Location = new System.Drawing.Point(389, 133);
            this.btnSearchWord.Name = "btnSearchWord";
            this.btnSearchWord.Size = new System.Drawing.Size(111, 23);
            this.btnSearchWord.TabIndex = 25;
            this.btnSearchWord.Text = "Search";
            this.btnSearchWord.UseVisualStyleBackColor = true;
            this.btnSearchWord.Click += new System.EventHandler(this.btnSearchWord_Click);
            // 
            // btnSearchLength
            // 
            this.btnSearchLength.Location = new System.Drawing.Point(389, 213);
            this.btnSearchLength.Name = "btnSearchLength";
            this.btnSearchLength.Size = new System.Drawing.Size(111, 23);
            this.btnSearchLength.TabIndex = 26;
            this.btnSearchLength.Text = "Search";
            this.btnSearchLength.UseVisualStyleBackColor = true;
            this.btnSearchLength.Click += new System.EventHandler(this.btnSearchLength_Click);
            // 
            // wordAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(710, 741);
            this.Controls.Add(this.btnSearchLength);
            this.Controls.Add(this.btnSearchWord);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.boxList);
            this.Controls.Add(this.srchLengthOutput);
            this.Controls.Add(this.srchWordOutput);
            this.Controls.Add(this.srchLenghtInput);
            this.Controls.Add(this.srchWordInput);
            this.Controls.Add(this.boxAverage);
            this.Controls.Add(this.boxShortest);
            this.Controls.Add(this.boxLongest);
            this.Controls.Add(this.boxMostCommon);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.lablTitle);
            this.Controls.Add(this.lablFilename);
            this.Controls.Add(this.lablAveNo);
            this.Controls.Add(this.lablLongest);
            this.Controls.Add(this.lablAbsNo);
            this.Controls.Add(this.lablAve);
            this.Controls.Add(this.lablAbs);
            this.Controls.Add(this.lablListUnique);
            this.Controls.Add(this.lablSearchLength);
            this.Controls.Add(this.lablSearchWord);
            this.Controls.Add(this.lablAverage);
            this.Controls.Add(this.lablShortest);
            this.Controls.Add(this.lablMostCommon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "wordAnalysis";
            this.Text = "Word Analysis";
            this.Load += new System.EventHandler(this.wordAnalysis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lablMostCommon;
        private System.Windows.Forms.Label lablShortest;
        private System.Windows.Forms.Label lablAverage;
        private System.Windows.Forms.Label lablSearchWord;
        private System.Windows.Forms.Label lablSearchLength;
        private System.Windows.Forms.Label lablListUnique;
        private System.Windows.Forms.Label lablAbs;
        private System.Windows.Forms.Label lablAve;
        private System.Windows.Forms.Label lablAbsNo;
        private System.Windows.Forms.Label lablLongest;
        private System.Windows.Forms.Label lablAveNo;
        private System.Windows.Forms.Label lablFilename;
        private System.Windows.Forms.Label lablTitle;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.TextBox boxMostCommon;
        private System.Windows.Forms.TextBox boxLongest;
        private System.Windows.Forms.TextBox boxShortest;
        private System.Windows.Forms.TextBox boxAverage;
        private System.Windows.Forms.TextBox srchWordInput;
        private System.Windows.Forms.TextBox srchLenghtInput;
        private System.Windows.Forms.TextBox srchWordOutput;
        private System.Windows.Forms.TextBox srchLengthOutput;
        private System.Windows.Forms.TextBox boxList;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnSearchWord;
        private System.Windows.Forms.Button btnSearchLength;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

