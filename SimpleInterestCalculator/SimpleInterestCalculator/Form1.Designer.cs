namespace SimpleInterestCalculator
{
    partial class interestCalculetorForm
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
            this.solveForlabel = new System.Windows.Forms.Label();
            this.principalLabel = new System.Windows.Forms.Label();
            this.rateLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.perYearLabel = new System.Windows.Forms.Label();
            this.selectOneLebel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.principalTextBox = new System.Windows.Forms.TextBox();
            this.rateTextBox = new System.Windows.Forms.TextBox();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.interestCalculateButton = new System.Windows.Forms.Button();
            this.solveForComboBox = new System.Windows.Forms.ComboBox();
            this.timeComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(80, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Simple Interest Calculetor";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // solveForlabel
            // 
            this.solveForlabel.AutoSize = true;
            this.solveForlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solveForlabel.Location = new System.Drawing.Point(27, 94);
            this.solveForlabel.Name = "solveForlabel";
            this.solveForlabel.Size = new System.Drawing.Size(69, 13);
            this.solveForlabel.TabIndex = 1;
            this.solveForlabel.Text = "Solve For :";
            // 
            // principalLabel
            // 
            this.principalLabel.AutoSize = true;
            this.principalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.principalLabel.Location = new System.Drawing.Point(27, 156);
            this.principalLabel.Name = "principalLabel";
            this.principalLabel.Size = new System.Drawing.Size(100, 13);
            this.principalLabel.TabIndex = 2;
            this.principalLabel.Text = "Principal (P): TK";
            // 
            // rateLabel
            // 
            this.rateLabel.AutoSize = true;
            this.rateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rateLabel.Location = new System.Drawing.Point(27, 182);
            this.rateLabel.Name = "rateLabel";
            this.rateLabel.Size = new System.Drawing.Size(79, 13);
            this.rateLabel.TabIndex = 3;
            this.rateLabel.Text = "Rate (R): TK";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(27, 221);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(54, 13);
            this.timeLabel.TabIndex = 4;
            this.timeLabel.Text = "Time (t):";
            // 
            // perYearLabel
            // 
            this.perYearLabel.AutoSize = true;
            this.perYearLabel.Location = new System.Drawing.Point(88, 204);
            this.perYearLabel.Name = "perYearLabel";
            this.perYearLabel.Size = new System.Drawing.Size(45, 13);
            this.perYearLabel.TabIndex = 5;
            this.perYearLabel.Text = "per year";
            // 
            // selectOneLebel
            // 
            this.selectOneLebel.AutoSize = true;
            this.selectOneLebel.Location = new System.Drawing.Point(171, 121);
            this.selectOneLebel.Name = "selectOneLebel";
            this.selectOneLebel.Size = new System.Drawing.Size(58, 13);
            this.selectOneLebel.TabIndex = 6;
            this.selectOneLebel.Text = "Select one";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(130, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Where:";
            // 
            // principalTextBox
            // 
            this.principalTextBox.Location = new System.Drawing.Point(133, 156);
            this.principalTextBox.Name = "principalTextBox";
            this.principalTextBox.Size = new System.Drawing.Size(185, 20);
            this.principalTextBox.TabIndex = 8;
            // 
            // rateTextBox
            // 
            this.rateTextBox.Location = new System.Drawing.Point(133, 182);
            this.rateTextBox.Name = "rateTextBox";
            this.rateTextBox.Size = new System.Drawing.Size(185, 20);
            this.rateTextBox.TabIndex = 9;
            // 
            // timeTextBox
            // 
            this.timeTextBox.Location = new System.Drawing.Point(133, 221);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(185, 20);
            this.timeTextBox.TabIndex = 10;
            // 
            // answerTextBox
            // 
            this.answerTextBox.Location = new System.Drawing.Point(30, 309);
            this.answerTextBox.Multiline = true;
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(288, 83);
            this.answerTextBox.TabIndex = 11;
            this.answerTextBox.Text = "Answer";
            this.answerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(30, 280);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 14;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // interestCalculateButton
            // 
            this.interestCalculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interestCalculateButton.Location = new System.Drawing.Point(243, 280);
            this.interestCalculateButton.Name = "interestCalculateButton";
            this.interestCalculateButton.Size = new System.Drawing.Size(75, 23);
            this.interestCalculateButton.TabIndex = 15;
            this.interestCalculateButton.Text = "Calculate";
            this.interestCalculateButton.UseVisualStyleBackColor = true;
            this.interestCalculateButton.Click += new System.EventHandler(this.interestCalculateButton_Click);
            // 
            // solveForComboBox
            // 
            this.solveForComboBox.FormattingEnabled = true;
            this.solveForComboBox.Location = new System.Drawing.Point(133, 94);
            this.solveForComboBox.Name = "solveForComboBox";
            this.solveForComboBox.Size = new System.Drawing.Size(185, 21);
            this.solveForComboBox.TabIndex = 16;
            this.solveForComboBox.Text = "--Select--";
            this.solveForComboBox.SelectedIndexChanged += new System.EventHandler(this.solveForComboBox_SelectedIndexChanged);
            // 
            // timeComboBox
            // 
            this.timeComboBox.FormattingEnabled = true;
            this.timeComboBox.Location = new System.Drawing.Point(133, 247);
            this.timeComboBox.Name = "timeComboBox";
            this.timeComboBox.Size = new System.Drawing.Size(185, 21);
            this.timeComboBox.TabIndex = 17;
            this.timeComboBox.Text = "--Select--";
            // 
            // interestCalculetorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(346, 404);
            this.Controls.Add(this.timeComboBox);
            this.Controls.Add(this.solveForComboBox);
            this.Controls.Add(this.interestCalculateButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(this.timeTextBox);
            this.Controls.Add(this.rateTextBox);
            this.Controls.Add(this.principalTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.selectOneLebel);
            this.Controls.Add(this.perYearLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.rateLabel);
            this.Controls.Add(this.principalLabel);
            this.Controls.Add(this.solveForlabel);
            this.Controls.Add(this.label1);
            this.Name = "interestCalculetorForm";
            this.Text = "Interest Calculetor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label solveForlabel;
        private System.Windows.Forms.Label principalLabel;
        private System.Windows.Forms.Label rateLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label perYearLabel;
        private System.Windows.Forms.Label selectOneLebel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox principalTextBox;
        private System.Windows.Forms.TextBox rateTextBox;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.TextBox answerTextBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button interestCalculateButton;
        private System.Windows.Forms.ComboBox solveForComboBox;
        private System.Windows.Forms.ComboBox timeComboBox;
    }
}

