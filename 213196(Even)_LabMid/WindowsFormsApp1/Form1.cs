using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int basicSalary = 0;
            if (EmployeeGrade.SelectedItem != null)
            {
                string grade = EmployeeGrade.SelectedItem.ToString();
                switch (grade)
                {
                    case "Director":
                        basicSalary = 1000000;
                        break;
                    case "Manager":
                        basicSalary = 50000;
                        break;
                    case "Project Manager":
                        basicSalary = 40000;
                        break;
                    case "Programmer":
                        basicSalary = 30000;
                        break;
                }
            }
            int totalBenefits = 0;
            if (Housing.Checked)
            {
                totalBenefits += 200000;
            }

            if (convenceAllowence.Checked)
            {
                totalBenefits += 15000;
            }
            if (OtherBenefits1.Checked)
            {
                totalBenefits += 10000;
            }
            if (OtherBenefits2.Checked)
            {
                totalBenefits += 10000;
            }
            int totalBonuses=0;
            
            foreach(var bonus in Bonusses.CheckedItems)
            {
                switch(bonus.ToString())
                {
                    case "Project Compeletion Bonus":
                        totalBonuses += 200000;
                        break ;
                    case "Year End Bonus":
                        totalBonuses += 300000;
                        break;
                    case "Performance Bonus":
                        totalBonuses += 25000;
                        break;
                    case "Custom Apperciation Bonus":
                        totalBonuses += 15000;
                        break;
                }
            }
            int Deductions = 0;
            if (!string.IsNullOrEmpty(ProvidentFundDeduction.Text))
            {
                Deductions += Convert.ToInt32(ProvidentFundDeduction.Text);   
            }
            if (!string.IsNullOrEmpty(MedicalDeduction.Text))
            {
                Deductions += Convert.ToInt32(MedicalDeduction.Text);
            }

            int TotalSalary = basicSalary + totalBenefits + totalBonuses - Deductions;
            MessageBox.Show(Convert.ToString(TotalSalary));
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
