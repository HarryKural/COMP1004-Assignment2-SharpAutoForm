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
    public partial class SharpAutoForm : Form
    {
        public SharpAutoForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method handles all the button clicks:
        /// using switch case by tagging each button to
        /// every case and performing their work.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void buttonClickHandler(object sender, EventArgs e)
        {
            Button ClickHandler = sender as Button;

            switch (ClickHandler.Tag.ToString())
            {
                // calculate
                case "Calculate":

                    break;

                case "Clear":
                    // clearing textboxes
                    BasePriceTextBox.Text = "";
                    AdditionalOptionsTextBox.Text = "";
                    SubTotalTextBox.Text = "";
                    SalesTaxTextBox.Text = "";
                    TotalTextBox.Text = "";
                    TradeInAllowanceTextBox.Text = "0";
                    AmountDueTextBox.Text = "";

                    // unchecking checkboxes
                    StereoSystemCheckBox.Checked = false;
                    LeatherInteriorCheckBox.Checked = false;
                    ComputerNavigationCheckBox.Checked = false;

                    // setting value of radiobuttons
                    StandardRadioButton.Checked = true;
                    PearlizedRadioButton.Checked = false;
                    CustomizedDetailingRadioButton.Checked = false;

                    // focusing cursor to the base price textbox
                    BasePriceTextBox.Focus();
                    break;

                case "Exit":
                    
                    break;
            }
        }

        private void _sharpAutoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void _exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Step 1. Create a new Form
            AboutForm aboutForm = new AboutForm();

            // Step 2. Show the About Form with Show Dialog (a model method to display the form)
            aboutForm.ShowDialog();
        }
    }
}
