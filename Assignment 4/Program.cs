/* Created By:      George Zhou
 * Student Number:  300613283
 * Date Last Modified: July 26, 2019
 * This program calculates the user's BMI after user inputs their weight and height
 * Revision:        1.0
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_4
{
    public static class Program
    {
        public static Person person;
        public static Dictionary<FormName, Form> Forms;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Forms = new Dictionary<FormName, Form>();
            Forms.Add(FormName.SPLASH_FORM, new SplashForm());
            Forms.Add(FormName.MAIN_FORM, new BMICalculator());
            Forms.Add(FormName.NUMPAD_FORM, new NumpadForm());

            person = new Person();

            Application.Run(Forms[FormName.SPLASH_FORM]);
        }
    }
}
