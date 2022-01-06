
namespace LabelTextButtonTestForm
{
    partial class LabelTextBoxButton
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
            this.inputPasswordTextBox = new System.Windows.Forms.TextBox();
            this.displayPassword = new System.Windows.Forms.Label();
            this.showPassButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputPasswordTextBox
            // 
            this.inputPasswordTextBox.Location = new System.Drawing.Point(27, 21);
            this.inputPasswordTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputPasswordTextBox.Name = "inputPasswordTextBox";
            this.inputPasswordTextBox.PasswordChar = '&';
            this.inputPasswordTextBox.Size = new System.Drawing.Size(261, 20);
            this.inputPasswordTextBox.TabIndex = 0;
            // 
            // displayPassword
            // 
            this.displayPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayPassword.Location = new System.Drawing.Point(27, 49);
            this.displayPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.displayPassword.Name = "displayPassword";
            this.displayPassword.Size = new System.Drawing.Size(261, 19);
            this.displayPassword.TabIndex = 1;
            // 
            // showPassButton
            // 
            this.showPassButton.Location = new System.Drawing.Point(110, 80);
            this.showPassButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.showPassButton.Name = "showPassButton";
            this.showPassButton.Size = new System.Drawing.Size(81, 19);
            this.showPassButton.TabIndex = 2;
            this.showPassButton.Text = "Show Me";
            this.showPassButton.UseVisualStyleBackColor = true;
            this.showPassButton.Click += new System.EventHandler(this.showPassButton_Click);
            // 
            // LabelTextBoxButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 116);
            this.Controls.Add(this.showPassButton);
            this.Controls.Add(this.displayPassword);
            this.Controls.Add(this.inputPasswordTextBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LabelTextBoxButton";
            this.Text = "Label, TextBox, and Button";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputPasswordTextBox;
        private System.Windows.Forms.Label displayPassword;
        private System.Windows.Forms.Button showPassButton;
    }
}

