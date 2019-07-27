/* Created By:      George Zhou
 * Student Number:  300613283
 * Date Last Modified: July 26, 2019
 * This program calculates the user's BMI after user inputs their weight and height
 * Revision:        1.0
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_4
{
    public partial class BMICalculator : Form
    {
        bool errorweight = true;
        bool errorheight = true;
        public BMICalculator()
        {
            InitializeComponent();
        }

        private void BMICalculator_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MyHeightTextBox_TextChanged(object sender, EventArgs e)
        {
            double value;
            SubmitButton.Enabled = false;
            if (Double.TryParse(MyHeightTextBox.Text, out value))
            {
                if (value <= 0)
                {
                    ErrorLabelA.Text = "Please enter a number greater than zero";

                }
                else {
                    ErrorLabelA.Text = string.Empty;
                    Program.person.Height = value;
                    errorheight = false;
                    if ((errorweight || errorheight) == false){
                        SubmitButton.Enabled = true; }
                }
            }
            else
            {
                ErrorLabelA.Text = "Please Enter a Valid Number";
            }
         }

        private void MyWeightTextBox_TextChanged(object sender, EventArgs e)
        {
            double value;
            SubmitButton.Enabled = false;
            if (Double.TryParse(MyWeightTextBox.Text, out value))
            {
                if (value <= 0)
                {
                    ErrorLabelA.Text = "Please enter a number greater than zero";
                }
                else
                {
                    ErrorLabelA.Text = string.Empty;
                    Program.person.Weight = value;
                    errorweight = false;
                    if ((errorweight || errorheight) == false)
                    {
                        SubmitButton.Enabled = true;
                    }
                }
            }
            else
            {
                ErrorLabelA.Text = "Please Enter a Valid Number";
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            int start_index;
            double BMI = Program.person.CalculateBMI(Program.person.Height, Program.person.Weight, ImperialRadio.Checked);
            ResultTextBox.Refresh();
            BMITextBox.Text= $"Your BMI is {BMI:F2}";

            if (BMI < 18.5) {
                start_index = ResultTextBox.Text.IndexOf("Underweight");
                ResultTextBox.Focus();
                ResultTextBox.Select(start_index, 11);
                    }
            else if (BMI >= 18.5 && BMI <= 24.9) {
                start_index = ResultTextBox.Text.IndexOf("Normal");
                ResultTextBox.Focus();
                ResultTextBox.Select(start_index, 6);
            }
            else if (BMI >= 25 && BMI <= 29.9) {
                start_index = ResultTextBox.Text.IndexOf("OverWeight");
                ResultTextBox.Focus();
                ResultTextBox.Select(start_index, 10);
            }
            else
            {
                start_index = ResultTextBox.Text.IndexOf("Obese");
                ResultTextBox.Focus();
                ResultTextBox.Select(start_index, 5);
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            MyHeightTextBox.Text = null;
            MyWeightTextBox.Text = null;
            errorweight = true;
            errorheight = true;
            ResultTextBox.Refresh();
            ErrorLabelA.Text = null;
        }
    }
}
