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
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SharpAutoForm());
        }
    }
}
