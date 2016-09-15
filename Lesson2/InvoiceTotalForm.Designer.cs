namespace Lesson2
{
    partial class InvoiceTotalForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SubTotalLabel = new System.Windows.Forms.Label();
            this.DiscountPercentLabel = new System.Windows.Forms.Label();
            this.DiscountAmountLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.SubtotalTextBox = new System.Windows.Forms.TextBox();
            this.DiscountPercentTextBox = new System.Windows.Forms.TextBox();
            this.DiscountAmountTextBox = new System.Windows.Forms.TextBox();
            this.TotalTextBoxLabel = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SubTotalLabel
            // 
            this.SubTotalLabel.AutoSize = true;
            this.SubTotalLabel.Location = new System.Drawing.Point(13, 15);
            this.SubTotalLabel.Name = "SubTotalLabel";
            this.SubTotalLabel.Size = new System.Drawing.Size(60, 17);
            this.SubTotalLabel.TabIndex = 0;
            this.SubTotalLabel.Text = "Subtotal";
            this.SubTotalLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // DiscountPercentLabel
            // 
            this.DiscountPercentLabel.AutoSize = true;
            this.DiscountPercentLabel.Location = new System.Drawing.Point(13, 43);
            this.DiscountPercentLabel.Name = "DiscountPercentLabel";
            this.DiscountPercentLabel.Size = new System.Drawing.Size(116, 17);
            this.DiscountPercentLabel.TabIndex = 1;
            this.DiscountPercentLabel.Text = "Discount Percent";
            // 
            // DiscountAmountLabel
            // 
            this.DiscountAmountLabel.AutoSize = true;
            this.DiscountAmountLabel.Location = new System.Drawing.Point(13, 71);
            this.DiscountAmountLabel.Name = "DiscountAmountLabel";
            this.DiscountAmountLabel.Size = new System.Drawing.Size(115, 17);
            this.DiscountAmountLabel.TabIndex = 2;
            this.DiscountAmountLabel.Text = "Discount Amount";
            this.DiscountAmountLabel.Click += new System.EventHandler(this.DiscountAmountLabel_Click);
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(13, 99);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(40, 17);
            this.TotalLabel.TabIndex = 3;
            this.TotalLabel.Text = "Total";
            // 
            // SubtotalTextBox
            // 
            this.SubtotalTextBox.Location = new System.Drawing.Point(157, 10);
            this.SubtotalTextBox.Name = "SubtotalTextBox";
            this.SubtotalTextBox.Size = new System.Drawing.Size(94, 22);
            this.SubtotalTextBox.TabIndex = 4;
            // 
            // DiscountPercentTextBox
            // 
            this.DiscountPercentTextBox.Location = new System.Drawing.Point(157, 38);
            this.DiscountPercentTextBox.Name = "DiscountPercentTextBox";
            this.DiscountPercentTextBox.ReadOnly = true;
            this.DiscountPercentTextBox.Size = new System.Drawing.Size(94, 22);
            this.DiscountPercentTextBox.TabIndex = 5;
            this.DiscountPercentTextBox.Text = "10.0%";
            // 
            // DiscountAmountTextBox
            // 
            this.DiscountAmountTextBox.Location = new System.Drawing.Point(157, 66);
            this.DiscountAmountTextBox.Name = "DiscountAmountTextBox";
            this.DiscountAmountTextBox.ReadOnly = true;
            this.DiscountAmountTextBox.Size = new System.Drawing.Size(94, 22);
            this.DiscountAmountTextBox.TabIndex = 6;
            // 
            // TotalTextBoxLabel
            // 
            this.TotalTextBoxLabel.Location = new System.Drawing.Point(157, 94);
            this.TotalTextBoxLabel.Name = "TotalTextBoxLabel";
            this.TotalTextBoxLabel.ReadOnly = true;
            this.TotalTextBoxLabel.Size = new System.Drawing.Size(94, 22);
            this.TotalTextBoxLabel.TabIndex = 7;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(53, 128);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 8;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(147, 128);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 9;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // InvoiceTotalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 173);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.TotalTextBoxLabel);
            this.Controls.Add(this.DiscountAmountTextBox);
            this.Controls.Add(this.DiscountPercentTextBox);
            this.Controls.Add(this.SubtotalTextBox);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.DiscountAmountLabel);
            this.Controls.Add(this.DiscountPercentLabel);
            this.Controls.Add(this.SubTotalLabel);
            this.Name = "InvoiceTotalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice Total";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SubTotalLabel;
        private System.Windows.Forms.Label DiscountPercentLabel;
        private System.Windows.Forms.Label DiscountAmountLabel;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.TextBox SubtotalTextBox;
        private System.Windows.Forms.TextBox DiscountPercentTextBox;
        private System.Windows.Forms.TextBox DiscountAmountTextBox;
        private System.Windows.Forms.TextBox TotalTextBoxLabel;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

