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
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            SplashTimer.Enabled = true;
            ProgressTimer.Enabled = true;
        }

        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            this.Hide();
            Program.Forms[FormName.MAIN_FORM].Show();
        }

        private void ProgressTimer_Tick(object sender, EventArgs e)
        {
            if (SplashProgressBar.Value < 100) {
                SplashProgressBar.Value+= 20;
            }
        }
    }
}
