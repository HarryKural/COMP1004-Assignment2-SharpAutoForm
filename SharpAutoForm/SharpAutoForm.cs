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

                    // it will not calculate if there is nothing in the fields
                    if (BasePriceTextBox.Text.ToString().Equals("") || TradeInAllowanceTextBox.Text.ToString().Equals(""))
                    {
                        MessageBox.Show("You must enter any valid value.", "Error: Invalid value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // variables used to do calculations and parsing them to Double
                        double subTotal;
                        double salesTax;
                        double total;
                        double amountDue;
                        double addOptions = Double.Parse(AdditionalOptionsTextBox.Text);
                        double basePrice = Double.Parse(BasePriceTextBox.Text);
                        double tradeIn = Double.Parse(TradeInAllowanceTextBox.Text);

                        // calculating subTotal by adding text of both textboxes
                        subTotal = addOptions + basePrice;

                            // setting text property of subTotal = calculated (ToString)
                            SubTotalTextBox.Text = subTotal.ToString();

                        // getting return value of calculateSalesTax method
                        salesTax = calculateSalesTax(subTotal);

                            // setting up salesTax value
                            SalesTaxTextBox.Text = salesTax.ToString();

                        // adding value of subTotal and salesTax
                        total = subTotal + salesTax;

                            // showing value of total in textbox
                            TotalTextBox.Text = total.ToString();

                        // calculating amount due
                        amountDue = total - tradeIn;

                            // showing value of amount due in text box
                            AmountDueTextBox.Text = amountDue.ToString();



                    }
                    break;

                case "Clear":
                    // clearing textboxes
                    BasePriceTextBox.Text = "";
                    AdditionalOptionsTextBox.Text = "0";
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
                    DialogResult result = MessageBox.Show("Are You Sure?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                        if (result == DialogResult.OK)
                        {
                            this.Close();
                        }
                    break;
            }
        }

        public void validValuesChecker(object sender, EventArgs e)
        {
            TextBox ValidValues = sender as TextBox;

                switch (ValidValues.Tag.ToString())
                {
                    case "basePrice":
                        if (BasePriceTextBox.Text != "")
                        { 
                         double basePrice = 0;
                            if (!Double.TryParse(BasePriceTextBox.Text, out basePrice))
                            {
                                MessageBox.Show("You must enter any number!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                BasePriceTextBox.Text = BasePriceTextBox.Text.Remove(BasePriceTextBox.Text.Length - 1);
                                BasePriceTextBox.SelectionStart = BasePriceTextBox.Text.Length;
                            }
                        }
                        break;

                    case "tradeIn":
                        if (TradeInAllowanceTextBox.Text != "")
                        { 
                         double tradeIn = 0;
                            if (!Double.TryParse(TradeInAllowanceTextBox.Text, out tradeIn))
                            {
                                MessageBox.Show("You must enter any number!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                TradeInAllowanceTextBox.Text = TradeInAllowanceTextBox.Text.Remove(TradeInAllowanceTextBox.Text.Length - 1);
                                TradeInAllowanceTextBox.SelectionStart = TradeInAllowanceTextBox.Text.Length;
                            }
                        }
                        break;
                }
        }

        private void _exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ExitButton.PerformClick();
        }

        private void calculateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CalculateButton.PerformClick();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ClearButton.PerformClick();
        }

        private void _aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Step 1. Create a new Form
            AboutForm aboutForm = new AboutForm();

            // Step 2. Show the About Form with Show Dialog (a model method to display the form)
            aboutForm.ShowDialog();
        }

        private void _fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show the Font Dialog
            AutoCenterFontDialog.ShowDialog();
                
                // Setting the selected font to specific textboxes
                BasePriceTextBox.Font = AutoCenterFontDialog.Font;
                AmountDueTextBox.Font = AutoCenterFontDialog.Font; 
        }

        private void _colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show Dialog for Color
            AutoCenterColorDialog.ShowDialog();

                // Setting the selected color to text in the textboxes
                BasePriceTextBox.ForeColor = AutoCenterColorDialog.Color;
                // because of the readOnly property of the textBox
                AmountDueTextBox.BackColor = AmountDueTextBox.BackColor;
                AmountDueTextBox.ForeColor = AutoCenterColorDialog.Color;
        }

        private void _changesHandler(object sender, EventArgs e)
        {
            double additionalOptions = 0;

            // variables to set price for accessories
            double stereo = 425.76;
            double leatherInterior = 987.41;
            double computerNavigation = 1741.23;
            double pearlized = 345.72;
            double customizedDetailing = 599.99;

            // Checking if checkboxes and radiobuttons are checked
            if (StereoSystemCheckBox.Checked == true)
                additionalOptions += stereo;
                   
            if (LeatherInteriorCheckBox.Checked == true)
                additionalOptions += leatherInterior;
              
            if (ComputerNavigationCheckBox.Checked == true)
                additionalOptions += computerNavigation;

            if (PearlizedRadioButton.Checked == true)
                additionalOptions += pearlized;

            if (CustomizedDetailingRadioButton.Checked == true)
                additionalOptions += customizedDetailing;
                    
            // showing the value of additional options textbox as ToString()
            AdditionalOptionsTextBox.Text = additionalOptions.ToString();
        }

        public double calculateSalesTax(double subTotal)
        {
            return subTotal * 0.13;
        }
    }
}

