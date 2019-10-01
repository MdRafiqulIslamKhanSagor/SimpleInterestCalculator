using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleInterestCalculator
{
    public partial class interestCalculetorForm : Form
    {
        public interestCalculetorForm()
        {
            InitializeComponent();
            interestCalculetorForm_Load();
         
        }

        private void interestCalculetorForm_Load()
        {
            loadSolveforAndTimeComboBox();
            
        }

        private void loadSolveforAndTimeComboBox()
        {
            solveForComboBox.Items.Add("Total P+I(A)");
            solveForComboBox.Items.Add("Principal(P)");
            solveForComboBox.Items.Add("Rate(R)");
            solveForComboBox.Items.Add("Time Period (t)");


            timeComboBox.Items.Add("days (365/yr)");
            timeComboBox.Items.Add("days (360/yr)");
            timeComboBox.Items.Add("weeks");
            timeComboBox.Items.Add("months");
            timeComboBox.Items.Add("quarters");
            timeComboBox.Items.Add("years");
            


        }
 

        private void solveForComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelTextChnange();
        }

        private void labelTextChnange()
        {
            string solveForComboBoxItem = solveForComboBox.Text;

            if (solveForComboBoxItem == "Total P+I(A)")
            {
                selectOneLebel.Text = " A = P(1 + rt)";
                principalLabel.Text = "Principal (P): $";
                rateLabel.Text = "Rate (R): %";
                timeLabel.Text = "Time (t):";
                perYearLabel.Text = "per year";
            }
            else if (solveForComboBoxItem == "Principal(P)")
            {
                selectOneLebel.Text = " P = A / (1 + rt)";
                principalLabel.Text = "Total P+I (A): $";
                rateLabel.Text = "Rate (R): %";
                timeLabel.Text = "Time (t):";
                perYearLabel.Text = "per year";



            }
            else if (solveForComboBoxItem == "Rate(R)")
            {
                selectOneLebel.Text = "Where: r = (1/t)(A/P - 1)";
                principalLabel.Text = "Total P+I (A): $";
                rateLabel.Text = "Principal (P): $";
                timeLabel.Text = "Time (t):";
                perYearLabel.Text = " ";
            }
            else if (solveForComboBoxItem == "Time Period (t)")
            {
                selectOneLebel.Text = "Where: t = (1/r)(A/P - 1)";
                principalLabel.Text = "Total P+I (A): $";
                rateLabel.Text = "Principal (P): $";
                timeLabel.Text = "Rate (R): %";
                timeComboBox.Hide();
                perYearLabel.Text = " ";

            }
            else
            {

            }
        }

        private void interestCalculateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(principalTextBox.Text) || string.IsNullOrWhiteSpace(rateTextBox.Text) || string.IsNullOrWhiteSpace(timeTextBox.Text))
            {
                MessageBox.Show("Please Enter valid value");
            }
            else
            {
                if (solveForComboBox.Text == "Total P+1 (A)")
                {
                    double P = Convert.ToDouble(principalTextBox.Text);
                    double R = Convert.ToDouble(rateTextBox.Text);
                    double r = R / 100;
                    if (timeComboBox.Text == "days(365/Yr)")
                    {

                        double time = Convert.ToDouble(timeTextBox.Text);
                        double t = time / 365;
                        double A = P * (1 + r * t);
                        answerTextBox.Text = "A=$" + Convert.ToString(A);
                    }
                    else if (timeComboBox.Text == "days(360/Yr)")
                    {

                        double time = Convert.ToDouble(timeTextBox.Text);
                        double t = time / 360;
                        double A = P * (1 + r * t);
                        answerTextBox.Text = "A=$" + Convert.ToString(A);
                    }
                    else if (timeComboBox.Text == "weeks")
                    {

                        double time = Convert.ToDouble(timeTextBox.Text);
                        double t = time / 52;
                        double A = P * (1 + r * t);
                        answerTextBox.Text = "A=$" + Convert.ToString(A);
                    }
                    else if (timeComboBox.Text == "months")
                    {

                        double time = Convert.ToDouble(timeTextBox.Text);
                        double t = time / 12;
                        double A = P * (1 + r * t);
                        answerTextBox.Text = "A=$" + Convert.ToString(A);
                    }
                    else if (timeComboBox.Text == "quarters")
                    {

                        double time = Convert.ToDouble(timeTextBox.Text);
                        double t = time / 4;
                        double A = P * (1 + r * t);
                        answerTextBox.Text = "A=$" + Convert.ToString(A);
                    }
                    else
                    {

                        double time = Convert.ToDouble(timeTextBox.Text);
                        double t = time;
                        double A = P * (1 + r * t);
                        answerTextBox.Text = "A=$" + Convert.ToString(A);
                    }

                }
                else if (solveForComboBox.Text == "Principal (P)")
                {
                    double A = Convert.ToDouble(principalTextBox.Text);
                    double R = Convert.ToDouble(rateTextBox.Text);
                    double r = R / 100;
                    if (timeComboBox.Text == "days(365/Yr)")
                    {

                        double time = Convert.ToDouble(timeTextBox.Text);
                        double t = time / 365;
                        double P = A / (1 + r * t);
                        answerTextBox.Text = "P=$" + Convert.ToString(P);
                    }
                    else if (timeComboBox.Text == "days(360/Yr)")
                    {

                        double time = Convert.ToDouble(timeTextBox.Text);
                        double t = time / 360;
                        double P = A / (1 + r * t);
                        answerTextBox.Text = "P=$" + Convert.ToString(P);
                    }
                    else if (timeComboBox.Text == "weeks")
                    {

                        double time = Convert.ToDouble(timeTextBox.Text);
                        double t = time / 52;
                        double P = A / (1 + r * t);
                        answerTextBox.Text = "P=$" + Convert.ToString(P);
                    }
                    else if (timeComboBox.Text == "months")
                    {

                        double time = Convert.ToDouble(timeTextBox.Text);
                        double t = time / 12;
                        double P = A / (1 + r * t);
                        answerTextBox.Text = "P=$" + Convert.ToString(P);
                    }
                    else if (timeComboBox.Text == "quarters")
                    {

                        double time = Convert.ToDouble(timeTextBox.Text);
                        double t = time / 4;
                        double P = A / (1 + r * t);
                        answerTextBox.Text = "P=$" + Convert.ToString(P);
                    }
                    else
                    {

                        double time = Convert.ToDouble(timeTextBox.Text);
                        double t = time;
                        double P = A / (1 + r * t);
                        answerTextBox.Text = "P=$" + Convert.ToString(P);
                    }

                }
                else if (solveForComboBox.Text == "Rate (R)")
                {
                    double A = Convert.ToDouble(principalTextBox.Text);
                    double P = Convert.ToDouble(rateTextBox.Text);
                    if (timeComboBox.Text == "days(365/Yr)")
                    {
                        double time = Convert.ToDouble(timeTextBox.Text);
                        double t = time / 365;
                        double r = (1 / t) / (A / P - 1);
                        answerTextBox.Text = "P=$" + Convert.ToString(r);
                    }
                    else if (timeComboBox.Text == "days(360/Yr)")
                    {
                        double time = Convert.ToDouble(timeTextBox.Text);
                        double t = time / 360;
                        double r = (1 / t) / (A / P - 1);
                        answerTextBox.Text = "P=$" + Convert.ToString(r);
                    }
                    else if (timeComboBox.Text == "weeks")
                    {
                        double time = Convert.ToDouble(timeTextBox.Text);
                        double t = time / 52;
                        double r = (1 / t) / (A / P - 1);
                        answerTextBox.Text = "P=$" + Convert.ToString(r);
                    }
                    else if (timeComboBox.Text == "months")
                    {
                        double time = Convert.ToDouble(timeTextBox.Text);
                        double t = time / 12;
                        double r = (1 / t) / (A / P - 1);
                        answerTextBox.Text = "P=$" + Convert.ToString(r);
                    }
                    else if (timeComboBox.Text == "quarters")
                    {
                        double time = Convert.ToDouble(timeTextBox.Text);
                        double t = time / 4;
                        double r = (1 / t) / (A / P - 1);
                        answerTextBox.Text = "P=$" + Convert.ToString(r);
                    }
                    else
                    {
                        double time = Convert.ToDouble(timeTextBox.Text);
                        double t = time;
                        double r = (1 / t) / (A / P - 1);
                        answerTextBox.Text = "P=$" + Convert.ToString(r);
                    }

                }
                else
                {
                    double A = Convert.ToDouble(principalTextBox.Text);
                    double R = Convert.ToDouble(rateTextBox.Text);
                    double P = Convert.ToDouble(rateTextBox.Text);
                    double r = R / 100;
                    double t = (1 / r) * (A / P - 1);
                    answerTextBox.Text = "t= " + Convert.ToString(t) + " years";

                }
            }
        }
    }
}
