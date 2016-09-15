using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson2
{
    public partial class InvoiceTotalForm : Form
    {
        public InvoiceTotalForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DiscountAmountLabel_Click(object sender, EventArgs e)
        {

        }


        private void CalculateButton_Click(object sender, EventArgs e)
        {
            // Local Variables
            // Read values from the Text Boxes
            const double DiscountPercent = 0.1;
            double SubTotal;
            double DiscountAmount;
            double Total;

            try
            {
                // convert String Values to Doubles
                SubTotal = Convert.ToDouble(SubtotalTextBox.Text);
                // DiscountAmount = SubTotal * 0.1
                DiscountAmount = SubTotal * DiscountPercent;
                // Total = Subtotal - DiscountAmount
                Total = SubTotal - DiscountAmount;

                // Display DiscountAmount in related Text Box
                DiscountAmountTextBox.Text = "$" + DiscountAmount.ToString("C2"); // two decimal places
                // Display Total in related Text Box
                TotalTextBoxLabel.Text = "$" + Total.ToString("C2");
            }
            catch (Exception exception)
            {
                MessageBox.Show("Invalid Data Entered", "Input Error");
                Debug.WriteLine(exception.Message);
                SubtotalTextBox.Focus();
                SubtotalTextBox.SelectAll();
            }
                       
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
