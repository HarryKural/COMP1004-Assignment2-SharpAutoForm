using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpAutoForm
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            // 1. Instantiate the next form
            SharpAutoForm sharpAutoCenter = new SharpAutoForm();

            // 2. pass a reference to the current form to the next form
            sharpAutoCenter.previousForm = this;

            this.SplashFormTimer.Enabled = false;

            sharpAutoCenter.Show();

            this.Hide();
        }
    }
}
