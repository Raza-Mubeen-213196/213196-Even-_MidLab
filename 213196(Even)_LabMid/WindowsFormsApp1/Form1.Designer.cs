namespace WindowsFormsApp1
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EmployeeGrade = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.EmployeeName = new System.Windows.Forms.TextBox();
            this.Housing = new System.Windows.Forms.CheckBox();
            this.OtherBenefits1 = new System.Windows.Forms.CheckBox();
            this.convenceAllowence = new System.Windows.Forms.CheckBox();
            this.OtherBenefits2 = new System.Windows.Forms.CheckBox();
            this.Bonuses = new System.Windows.Forms.Label();
            this.Bonusses = new System.Windows.Forms.CheckedListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ProvidentFundDeduction = new System.Windows.Forms.TextBox();
            this.MedicalDeduction = new System.Windows.Forms.TextBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.Ok = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(220, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Salary Calculation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Grade:";
            // 
            // EmployeeGrade
            // 
            this.EmployeeGrade.FormattingEnabled = true;
            this.EmployeeGrade.Items.AddRange(new object[] {
            "Director",
            "Manager",
            "Project Manager",
            "Programmer"});
            this.EmployeeGrade.Location = new System.Drawing.Point(65, 86);
            this.EmployeeGrade.Name = "EmployeeGrade";
            this.EmployeeGrade.Size = new System.Drawing.Size(121, 21);
            this.EmployeeGrade.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(112, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 128);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Salary";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(19, 30);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(64, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "100,000";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(206, 82);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(58, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "30,000";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(206, 30);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(58, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "50,000";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(19, 82);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(58, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "40,000";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.OtherBenefits2);
            this.groupBox2.Controls.Add(this.convenceAllowence);
            this.groupBox2.Controls.Add(this.OtherBenefits1);
            this.groupBox2.Controls.Add(this.Housing);
            this.groupBox2.Location = new System.Drawing.Point(112, 264);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(353, 125);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Benefits";
            // 
            // EmployeeName
            // 
            this.EmployeeName.Location = new System.Drawing.Point(65, 41);
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.Size = new System.Drawing.Size(121, 20);
            this.EmployeeName.TabIndex = 8;
            // 
            // Housing
            // 
            this.Housing.AutoSize = true;
            this.Housing.Location = new System.Drawing.Point(19, 34);
            this.Housing.Name = "Housing";
            this.Housing.Size = new System.Drawing.Size(122, 17);
            this.Housing.TabIndex = 9;
            this.Housing.Text = "Houssing Allowance";
            this.Housing.UseVisualStyleBackColor = true;
            // 
            // OtherBenefits1
            // 
            this.OtherBenefits1.AutoSize = true;
            this.OtherBenefits1.Location = new System.Drawing.Point(19, 86);
            this.OtherBenefits1.Name = "OtherBenefits1";
            this.OtherBenefits1.Size = new System.Drawing.Size(102, 17);
            this.OtherBenefits1.TabIndex = 10;
            this.OtherBenefits1.Text = "Other Benefits 1";
            this.OtherBenefits1.UseVisualStyleBackColor = true;
            this.OtherBenefits1.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // convenceAllowence
            // 
            this.convenceAllowence.AutoSize = true;
            this.convenceAllowence.Location = new System.Drawing.Point(193, 34);
            this.convenceAllowence.Name = "convenceAllowence";
            this.convenceAllowence.Size = new System.Drawing.Size(126, 17);
            this.convenceAllowence.TabIndex = 11;
            this.convenceAllowence.Text = "convence Allowance";
            this.convenceAllowence.UseVisualStyleBackColor = true;
            // 
            // OtherBenefits2
            // 
            this.OtherBenefits2.AutoSize = true;
            this.OtherBenefits2.Location = new System.Drawing.Point(193, 86);
            this.OtherBenefits2.Name = "OtherBenefits2";
            this.OtherBenefits2.Size = new System.Drawing.Size(102, 17);
            this.OtherBenefits2.TabIndex = 12;
            this.OtherBenefits2.Text = "Other Benefits 2";
            this.OtherBenefits2.UseVisualStyleBackColor = true;
            this.OtherBenefits2.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // Bonuses
            // 
            this.Bonuses.AutoSize = true;
            this.Bonuses.Location = new System.Drawing.Point(128, 414);
            this.Bonuses.Name = "Bonuses";
            this.Bonuses.Size = new System.Drawing.Size(51, 13);
            this.Bonuses.TabIndex = 9;
            this.Bonuses.Text = "Bonuses:";
            // 
            // Bonusses
            // 
            this.Bonusses.FormattingEnabled = true;
            this.Bonusses.Items.AddRange(new object[] {
            "Project Compeletion Bonus",
            "Year End Bonus",
            "Performance Bonus",
            "Custom Apperciation Bonus"});
            this.Bonusses.Location = new System.Drawing.Point(185, 395);
            this.Bonusses.Name = "Bonusses";
            this.Bonusses.Size = new System.Drawing.Size(246, 64);
            this.Bonusses.TabIndex = 10;
            this.Bonusses.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.MedicalDeduction);
            this.groupBox3.Controls.Add(this.ProvidentFundDeduction);
            this.groupBox3.Location = new System.Drawing.Point(112, 476);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(353, 100);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Deduction";
            // 
            // ProvidentFundDeduction
            // 
            this.ProvidentFundDeduction.Location = new System.Drawing.Point(73, 30);
            this.ProvidentFundDeduction.Name = "ProvidentFundDeduction";
            this.ProvidentFundDeduction.Size = new System.Drawing.Size(211, 20);
            this.ProvidentFundDeduction.TabIndex = 0;
            // 
            // MedicalDeduction
            // 
            this.MedicalDeduction.Location = new System.Drawing.Point(73, 65);
            this.MedicalDeduction.Name = "MedicalDeduction";
            this.MedicalDeduction.Size = new System.Drawing.Size(211, 20);
            this.MedicalDeduction.TabIndex = 1;
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(111, 613);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(75, 23);
            this.Calculate.TabIndex = 12;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(390, 613);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(75, 23);
            this.Ok.TabIndex = 13;
            this.Ok.Text = "Ok";
            this.Ok.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 658);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Bonusses);
            this.Controls.Add(this.Bonuses);
            this.Controls.Add(this.EmployeeName);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.EmployeeGrade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox EmployeeGrade;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox OtherBenefits2;
        private System.Windows.Forms.CheckBox convenceAllowence;
        private System.Windows.Forms.CheckBox OtherBenefits1;
        private System.Windows.Forms.CheckBox Housing;
        private System.Windows.Forms.TextBox EmployeeName;
        private System.Windows.Forms.Label Bonuses;
        private System.Windows.Forms.CheckedListBox Bonusses;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox MedicalDeduction;
        private System.Windows.Forms.TextBox ProvidentFundDeduction;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Button Ok;
    }
}

