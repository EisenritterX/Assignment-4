/* Created By:      George Zhou
 * Student Number:  300613283
 * Date Last Modified: July 26, 2019
 * This program calculates the user's BMI after user inputs their weight and height
 * Revision:        1.0
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_4
{
    public class Person
    {
        public double Height { get; set; }
        public double Weight { get; set; }

        public double CalculateBMI(double height, double weight, bool imp)
        {
            double BMI;

            if (imp)
            {
                BMI = (weight * 703 / Math.Pow(height, 2));
            }
            else
            {
                BMI = (weight / Math.Pow(height, 2));
            }

            return BMI;
        }
    }
}
