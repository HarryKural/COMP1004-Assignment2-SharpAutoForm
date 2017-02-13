/// <summary>
/// App name:           Sharp Auto Form
/// Author's name:      Harshit Sharma
/// Student Number#:    200333254
/// App Creation Date:  Feb 04, 2017
/// Last Modified Date: Feb 12, 2017
/// App description:    This program calculates the
///                     amount due on a New or Used Vehicle based on
///                     accessories and options selected and a trade-in value (if any).
/// Rapid Application Development - Assignment 2
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpAutoForm
{
    public static class Program
    {
        // declared public static form - Application GLOBAL
        public static SplashForm MySplashForm;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Initialize SplashForm and CalculatorForm
            Program.MySplashForm = new SplashForm();

            Application.Run(Program.MySplashForm);
        }
    }
}
