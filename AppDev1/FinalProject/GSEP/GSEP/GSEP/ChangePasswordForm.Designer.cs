namespace GSEP
{
    partial class ChangePasswordForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.oldPassTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.newPassTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.newPassTextBox2 = new System.Windows.Forms.TextBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.showPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(564, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "Change your Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 33);
            this.label2.TabIndex = 10;
            this.label2.Text = "Old Password:";
            // 
            // oldPassTextBox
            // 
            this.oldPassTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.oldPassTextBox.Location = new System.Drawing.Point(268, 124);
            this.oldPassTextBox.Multiline = true;
            this.oldPassTextBox.Name = "oldPassTextBox";
            this.oldPassTextBox.PasswordChar = '*';
            this.oldPassTextBox.Size = new System.Drawing.Size(373, 26);
            this.oldPassTextBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Banner", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(100, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 33);
            this.label3.TabIndex = 12;
            this.label3.Text = "New Password:";
            // 
            // newPassTextBox
            // 
            this.newPassTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newPassTextBox.Location = new System.Drawing.Point(268, 195);
            this.newPassTextBox.Multiline = true;
            this.newPassTextBox.Name = "newPassTextBox";
            this.newPassTextBox.PasswordChar = '*';
            this.newPassTextBox.Size = new System.Drawing.Size(373, 26);
            this.newPassTextBox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Banner", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 33);
            this.label4.TabIndex = 14;
            this.label4.Text = "Re-enter New Password:";
            // 
            // newPassTextBox2
            // 
            this.newPassTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newPassTextBox2.Location = new System.Drawing.Point(268, 273);
            this.newPassTextBox2.Multiline = true;
            this.newPassTextBox2.Name = "newPassTextBox2";
            this.newPassTextBox2.PasswordChar = '*';
            this.newPassTextBox2.Size = new System.Drawing.Size(373, 26);
            this.newPassTextBox2.TabIndex = 13;
            // 
            // confirmButton
            // 
            this.confirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmButton.Font = new System.Drawing.Font("Sitka Banner", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.Location = new System.Drawing.Point(182, 362);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(523, 51);
            this.confirmButton.TabIndex = 15;
            this.confirmButton.Text = "Confirm Change";
            this.confirmButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.errorLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(90, 430);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 21);
            this.errorLabel.TabIndex = 16;
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // showPasswordCheckBox
            // 
            this.showPasswordCheckBox.AutoSize = true;
            this.showPasswordCheckBox.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPasswordCheckBox.Location = new System.Drawing.Point(83, 312);
            this.showPasswordCheckBox.Name = "showPasswordCheckBox";
            this.showPasswordCheckBox.Size = new System.Drawing.Size(134, 28);
            this.showPasswordCheckBox.TabIndex = 17;
            this.showPasswordCheckBox.Text = "Show Password";
            this.showPasswordCheckBox.UseVisualStyleBackColor = true;
            this.showPasswordCheckBox.CheckedChanged += new System.EventHandler(this.showPasswordCheckBox_CheckedChanged);
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(684, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 223);
            this.label5.TabIndex = 18;
            this.label5.Text = "\r\nPassword Requirements: \r\n\r\nMust Contain:\r\nCapital and Lowercase letters,\r\nAt le" +
    "ast 1 number and 1 symbol\r\n\r\nCannot Contain:\r\n- the text \"defaultPass\"\r\n";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButton.Font = new System.Drawing.Font("Sitka Banner", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton.Location = new System.Drawing.Point(758, 0);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(127, 38);
            this.menuButton.TabIndex = 61;
            this.menuButton.Text = "Return to Menu";
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(886, 471);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.showPasswordCheckBox);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.newPassTextBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.newPassTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.oldPassTextBox);
            this.Controls.Add(this.label1);
            this.Name = "ChangePasswordForm";
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.ChangePasswordForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox oldPassTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox newPassTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox newPassTextBox2;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.CheckBox showPasswordCheckBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button menuButton;
    }
}