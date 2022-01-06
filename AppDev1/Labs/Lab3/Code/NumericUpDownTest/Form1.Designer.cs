
namespace NumericUpDownTest
{
    partial class InterestCalculatorForm
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
            this.principalLabel = new System.Windows.Forms.Label();
            this.principalTextBox = new System.Windows.Forms.TextBox();
            this.interestTextBox = new System.Windows.Forms.TextBox();
            this.interestRateLabel = new System.Windows.Forms.Label();
            this.yearsLabel = new System.Windows.Forms.Label();
            this.yearUpDown = new System.Windows.Forms.NumericUpDown();
            this.calculateButton = new System.Windows.Forms.Button();
            this.yearlyAccountBalance = new System.Windows.Forms.Label();
            this.displayTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.yearUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // principalLabel
            // 
            this.principalLabel.AutoSize = true;
            this.principalLabel.Location = new System.Drawing.Point(41, 13);
            this.principalLabel.Name = "principalLabel";
            this.principalLabel.Size = new System.Drawing.Size(66, 17);
            this.principalLabel.TabIndex = 0;
            this.principalLabel.Text = "Principal:";
            // 
            // principalTextBox
            // 
            this.principalTextBox.Location = new System.Drawing.Point(113, 13);
            this.principalTextBox.Name = "principalTextBox";
            this.principalTextBox.Size = new System.Drawing.Size(127, 22);
            this.principalTextBox.TabIndex = 1;
            // 
            // interestTextBox
            // 
            this.interestTextBox.Location = new System.Drawing.Point(113, 41);
            this.interestTextBox.Name = "interestTextBox";
            this.interestTextBox.Size = new System.Drawing.Size(127, 22);
            this.interestTextBox.TabIndex = 2;
            // 
            // interestRateLabel
            // 
            this.interestRateLabel.AutoSize = true;
            this.interestRateLabel.Location = new System.Drawing.Point(14, 41);
            this.interestRateLabel.Name = "interestRateLabel";
            this.interestRateLabel.Size = new System.Drawing.Size(93, 17);
            this.interestRateLabel.TabIndex = 3;
            this.interestRateLabel.Text = "Interest Rate:";
            // 
            // yearsLabel
            // 
            this.yearsLabel.AutoSize = true;
            this.yearsLabel.Location = new System.Drawing.Point(58, 70);
            this.yearsLabel.Name = "yearsLabel";
            this.yearsLabel.Size = new System.Drawing.Size(49, 17);
            this.yearsLabel.TabIndex = 4;
            this.yearsLabel.Text = "Years:";
            // 
            // yearUpDown
            // 
            this.yearUpDown.Location = new System.Drawing.Point(113, 70);
            this.yearUpDown.Name = "yearUpDown";
            this.yearUpDown.ReadOnly = true;
            this.yearUpDown.Size = new System.Drawing.Size(127, 22);
            this.yearUpDown.TabIndex = 5;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(247, 12);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(115, 23);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // yearlyAccountBalance
            // 
            this.yearlyAccountBalance.AutoSize = true;
            this.yearlyAccountBalance.Location = new System.Drawing.Point(17, 112);
            this.yearlyAccountBalance.Name = "yearlyAccountBalance";
            this.yearlyAccountBalance.Size = new System.Drawing.Size(162, 17);
            this.yearlyAccountBalance.TabIndex = 8;
            this.yearlyAccountBalance.Text = "Yearly Account Balance:";
            // 
            // displayTextBox
            // 
            this.displayTextBox.Location = new System.Drawing.Point(17, 133);
            this.displayTextBox.Multiline = true;
            this.displayTextBox.Name = "displayTextBox";
            this.displayTextBox.ReadOnly = true;
            this.displayTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.displayTextBox.Size = new System.Drawing.Size(332, 172);
            this.displayTextBox.TabIndex = 9;
            // 
            // InterestCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 317);
            this.Controls.Add(this.displayTextBox);
            this.Controls.Add(this.yearlyAccountBalance);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.yearUpDown);
            this.Controls.Add(this.yearsLabel);
            this.Controls.Add(this.interestRateLabel);
            this.Controls.Add(this.interestTextBox);
            this.Controls.Add(this.principalTextBox);
            this.Controls.Add(this.principalLabel);
            this.Name = "InterestCalculatorForm";
            this.Text = "Interest Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.yearUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label principalLabel;
        private System.Windows.Forms.TextBox principalTextBox;
        private System.Windows.Forms.TextBox interestTextBox;
        private System.Windows.Forms.Label interestRateLabel;
        private System.Windows.Forms.Label yearsLabel;
        private System.Windows.Forms.NumericUpDown yearUpDown;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label yearlyAccountBalance;
        private System.Windows.Forms.TextBox displayTextBox;
    }
}

