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

// importing pre-existing libraries
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// name of the project
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
                    // showing up confirm message when exit button clicked
                    DialogResult result = MessageBox.Show("Are You Sure?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                        if (result == DialogResult.OK)
                        {
                            this.Close();
                        }
                    break;
            } // end of switch
        } // end of buttonClickHandler

        /// <summary>
        /// This method validates if entered value is number as well as it's
        /// not empty. Using switch statement for both textboxes and tagging them.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void validValuesChecker(object sender, EventArgs e)
        {
            TextBox ValidValues = sender as TextBox;

                switch (ValidValues.Tag.ToString())
                {
                    case "basePrice":
                        if (BasePriceTextBox.Text != "")
                        {
                         // setting value of variable to 0
                         double basePrice = 0;
                            // parsing textBox to double
                            if (!Double.TryParse(BasePriceTextBox.Text, out basePrice))
                            {
                                // showing messageBox if entered value is not number
                                MessageBox.Show("You must enter any number!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                
                                // this will remove last entered value if it is not number
                                BasePriceTextBox.Text = BasePriceTextBox.Text.Remove(BasePriceTextBox.Text.Length - 1);

                                // move the cursor to the last value
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
                } // end of switch
        } // end of validValuesChecker

        /// <summary>
        /// This method clicks the exit button and then does it's work
        /// whatever the button's function is. (PerformClick())
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ExitButton.PerformClick();
        }

        /// <summary>
        /// This method clicks the calculate button and then does it's work
        /// whatever the button's function is.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void calculateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CalculateButton.PerformClick();
        }

        /// <summary>
        /// This method clicks the clear button and then does it's work
        /// whatever the button's function is.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ClearButton.PerformClick();
        }

        /// <summary>
        /// This method makes a new about form and then
        /// displays that when clicked about button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Step 1. Create a new Form
            AboutForm aboutForm = new AboutForm();

            // Step 2. Show the About Form with Show Dialog (a model method to display the form)
            aboutForm.ShowDialog();
        }

        /// <summary>
        /// This method performs the function when the font
        /// button is clicked by displaying font dialog box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show the Font Dialog
            AutoCenterFontDialog.ShowDialog();
                
                // Setting the selected font to specific textboxes
                BasePriceTextBox.Font = AutoCenterFontDialog.Font;
                AmountDueTextBox.Font = AutoCenterFontDialog.Font; 
        }

        /// <summary>
        /// This method performs the function when the color
        /// button is clicked by displaying color dialog box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// This method is used to check the changes in the checkboxes
        /// and radioButtons then accordingly sets the addtional options
        /// textbox value, afterwards display it as ToString().
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _changesHandler(object sender, EventArgs e)
        {
            // setting value of variable to 0
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
        } // end of _changesHandler

        /// <summary>
        /// This method is used to calculate the sales tax of subTotal field
        /// and then return the calculated value.
        /// </summary>
        /// <param name="subTotal"></param>
        /// <returns></returns>
        public double calculateSalesTax(double subTotal)
        {
            return subTotal * 0.13;
        }

    } // end of class

} // end of namespace
