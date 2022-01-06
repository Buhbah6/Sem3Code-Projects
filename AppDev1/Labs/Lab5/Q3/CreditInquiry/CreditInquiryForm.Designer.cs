
namespace CreditInquiry
{
    partial class CreditInquiryForm
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
            this.displayTextBox = new System.Windows.Forms.TextBox();
            this.openButton = new System.Windows.Forms.Button();
            this.creditButton = new System.Windows.Forms.Button();
            this.debitButton = new System.Windows.Forms.Button();
            this.zeroButton = new System.Windows.Forms.Button();
            this.doneButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // displayTextBox
            // 
            this.displayTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayTextBox.Location = new System.Drawing.Point(13, 13);
            this.displayTextBox.Multiline = true;
            this.displayTextBox.Name = "displayTextBox";
            this.displayTextBox.Size = new System.Drawing.Size(549, 103);
            this.displayTextBox.TabIndex = 0;
            // 
            // openButton
            // 
            this.openButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.openButton.Location = new System.Drawing.Point(13, 135);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(105, 31);
            this.openButton.TabIndex = 1;
            this.openButton.Text = "Open File";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // creditButton
            // 
            this.creditButton.Enabled = false;
            this.creditButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.creditButton.Location = new System.Drawing.Point(124, 135);
            this.creditButton.Name = "creditButton";
            this.creditButton.Size = new System.Drawing.Size(105, 31);
            this.creditButton.TabIndex = 2;
            this.creditButton.Text = "Credit Balances";
            this.creditButton.UseVisualStyleBackColor = true;
            this.creditButton.Click += new System.EventHandler(this.getBalances_Click);
            // 
            // debitButton
            // 
            this.debitButton.Enabled = false;
            this.debitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.debitButton.Location = new System.Drawing.Point(235, 135);
            this.debitButton.Name = "debitButton";
            this.debitButton.Size = new System.Drawing.Size(105, 31);
            this.debitButton.TabIndex = 3;
            this.debitButton.Text = "Debit Balances";
            this.debitButton.UseVisualStyleBackColor = true;
            this.debitButton.Click += new System.EventHandler(this.getBalances_Click);
            // 
            // zeroButton
            // 
            this.zeroButton.Enabled = false;
            this.zeroButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.zeroButton.Location = new System.Drawing.Point(346, 135);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(105, 31);
            this.zeroButton.TabIndex = 4;
            this.zeroButton.Text = "Zero Balances";
            this.zeroButton.UseVisualStyleBackColor = true;
            this.zeroButton.Click += new System.EventHandler(this.getBalances_Click);
            // 
            // doneButton
            // 
            this.doneButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.doneButton.Location = new System.Drawing.Point(457, 135);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(105, 31);
            this.doneButton.TabIndex = 5;
            this.doneButton.Text = "Done";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // CreditInquiryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 186);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.zeroButton);
            this.Controls.Add(this.debitButton);
            this.Controls.Add(this.creditButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.displayTextBox);
            this.Name = "CreditInquiryForm";
            this.Text = "Credit Inquiry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox displayTextBox;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button creditButton;
        private System.Windows.Forms.Button debitButton;
        private System.Windows.Forms.Button zeroButton;
        private System.Windows.Forms.Button doneButton;
    }
}

