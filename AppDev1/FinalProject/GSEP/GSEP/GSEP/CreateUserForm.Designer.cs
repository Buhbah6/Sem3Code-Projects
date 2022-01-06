namespace GSEP
{
    partial class CreateUserForm
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
            this.fNameTextBox = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lNameTextBox = new System.Windows.Forms.TextBox();
            this.depTextBox = new System.Windows.Forms.TextBox();
            this.permsGroupBox = new System.Windows.Forms.GroupBox();
            this.transactionViewCheckBox = new System.Windows.Forms.CheckBox();
            this.changeProductsCheckBox = new System.Windows.Forms.CheckBox();
            this.createUserCheckBox = new System.Windows.Forms.CheckBox();
            this.employeeViewCheckBox = new System.Windows.Forms.CheckBox();
            this.transactionCheckBox = new System.Windows.Forms.CheckBox();
            this.passwordCheckBox = new System.Windows.Forms.CheckBox();
            this.returnButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.permsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(277, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create Users";
            // 
            // fNameTextBox
            // 
            this.fNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fNameTextBox.Location = new System.Drawing.Point(220, 109);
            this.fNameTextBox.Multiline = true;
            this.fNameTextBox.Name = "fNameTextBox";
            this.fNameTextBox.Size = new System.Drawing.Size(373, 26);
            this.fNameTextBox.TabIndex = 1;
            // 
            // createButton
            // 
            this.createButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createButton.Font = new System.Drawing.Font("Sitka Banner", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createButton.Location = new System.Drawing.Point(70, 286);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(523, 51);
            this.createButton.TabIndex = 5;
            this.createButton.Text = "Create";
            this.createButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 43);
            this.label2.TabIndex = 8;
            this.label2.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Banner", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 43);
            this.label3.TabIndex = 9;
            this.label3.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Banner", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 43);
            this.label4.TabIndex = 10;
            this.label4.Text = "Department:";
            // 
            // lNameTextBox
            // 
            this.lNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lNameTextBox.Location = new System.Drawing.Point(220, 169);
            this.lNameTextBox.Multiline = true;
            this.lNameTextBox.Name = "lNameTextBox";
            this.lNameTextBox.Size = new System.Drawing.Size(373, 26);
            this.lNameTextBox.TabIndex = 11;
            // 
            // depTextBox
            // 
            this.depTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.depTextBox.Location = new System.Drawing.Point(220, 231);
            this.depTextBox.Multiline = true;
            this.depTextBox.Name = "depTextBox";
            this.depTextBox.Size = new System.Drawing.Size(373, 26);
            this.depTextBox.TabIndex = 12;
            // 
            // permsGroupBox
            // 
            this.permsGroupBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.permsGroupBox.Controls.Add(this.transactionViewCheckBox);
            this.permsGroupBox.Controls.Add(this.changeProductsCheckBox);
            this.permsGroupBox.Controls.Add(this.createUserCheckBox);
            this.permsGroupBox.Controls.Add(this.employeeViewCheckBox);
            this.permsGroupBox.Controls.Add(this.transactionCheckBox);
            this.permsGroupBox.Controls.Add(this.passwordCheckBox);
            this.permsGroupBox.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.permsGroupBox.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.permsGroupBox.Location = new System.Drawing.Point(619, 109);
            this.permsGroupBox.Name = "permsGroupBox";
            this.permsGroupBox.Size = new System.Drawing.Size(215, 189);
            this.permsGroupBox.TabIndex = 13;
            this.permsGroupBox.TabStop = false;
            this.permsGroupBox.Text = "Permissions";
            // 
            // transactionViewCheckBox
            // 
            this.transactionViewCheckBox.AutoSize = true;
            this.transactionViewCheckBox.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionViewCheckBox.Location = new System.Drawing.Point(6, 151);
            this.transactionViewCheckBox.Name = "transactionViewCheckBox";
            this.transactionViewCheckBox.Size = new System.Drawing.Size(149, 28);
            this.transactionViewCheckBox.TabIndex = 5;
            this.transactionViewCheckBox.Text = "View Transactions";
            this.transactionViewCheckBox.UseVisualStyleBackColor = true;
            // 
            // changeProductsCheckBox
            // 
            this.changeProductsCheckBox.AutoSize = true;
            this.changeProductsCheckBox.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeProductsCheckBox.Location = new System.Drawing.Point(6, 21);
            this.changeProductsCheckBox.Name = "changeProductsCheckBox";
            this.changeProductsCheckBox.Size = new System.Drawing.Size(176, 28);
            this.changeProductsCheckBox.TabIndex = 0;
            this.changeProductsCheckBox.Text = "Add/Remove Products";
            this.changeProductsCheckBox.UseVisualStyleBackColor = true;
            // 
            // createUserCheckBox
            // 
            this.createUserCheckBox.AutoSize = true;
            this.createUserCheckBox.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createUserCheckBox.Location = new System.Drawing.Point(6, 47);
            this.createUserCheckBox.Name = "createUserCheckBox";
            this.createUserCheckBox.Size = new System.Drawing.Size(112, 28);
            this.createUserCheckBox.TabIndex = 1;
            this.createUserCheckBox.Text = "Create Users";
            this.createUserCheckBox.UseVisualStyleBackColor = true;
            // 
            // employeeViewCheckBox
            // 
            this.employeeViewCheckBox.AutoSize = true;
            this.employeeViewCheckBox.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeViewCheckBox.Location = new System.Drawing.Point(6, 125);
            this.employeeViewCheckBox.Name = "employeeViewCheckBox";
            this.employeeViewCheckBox.Size = new System.Drawing.Size(137, 28);
            this.employeeViewCheckBox.TabIndex = 4;
            this.employeeViewCheckBox.Text = "View Employees";
            this.employeeViewCheckBox.UseVisualStyleBackColor = true;
            // 
            // transactionCheckBox
            // 
            this.transactionCheckBox.AutoSize = true;
            this.transactionCheckBox.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionCheckBox.Location = new System.Drawing.Point(6, 73);
            this.transactionCheckBox.Name = "transactionCheckBox";
            this.transactionCheckBox.Size = new System.Drawing.Size(178, 28);
            this.transactionCheckBox.TabIndex = 2;
            this.transactionCheckBox.Text = "Complete Transactions";
            this.transactionCheckBox.UseVisualStyleBackColor = true;
            // 
            // passwordCheckBox
            // 
            this.passwordCheckBox.AutoSize = true;
            this.passwordCheckBox.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordCheckBox.Location = new System.Drawing.Point(6, 99);
            this.passwordCheckBox.Name = "passwordCheckBox";
            this.passwordCheckBox.Size = new System.Drawing.Size(161, 28);
            this.passwordCheckBox.TabIndex = 3;
            this.passwordCheckBox.Text = "Generate Passwords";
            this.passwordCheckBox.UseVisualStyleBackColor = true;
            // 
            // returnButton
            // 
            this.returnButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.returnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnButton.Font = new System.Drawing.Font("Sitka Banner", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnButton.Location = new System.Drawing.Point(28, 427);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(239, 57);
            this.returnButton.TabIndex = 14;
            this.returnButton.Text = "Return to Menu";
            this.returnButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Sitka Display Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(320, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(514, 95);
            this.label5.TabIndex = 15;
            this.label5.Text = "Use the checkboxes on the right to allot permissions to the user being created. E" +
    "mployee ID and default password will be auto-generated.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CreateUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(873, 518);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.permsGroupBox);
            this.Controls.Add(this.depTextBox);
            this.Controls.Add(this.lNameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.fNameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "CreateUserForm";
            this.Text = "Create User";
            this.Load += new System.EventHandler(this.CreateUserForm_Load);
            this.permsGroupBox.ResumeLayout(false);
            this.permsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fNameTextBox;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lNameTextBox;
        private System.Windows.Forms.TextBox depTextBox;
        private System.Windows.Forms.GroupBox permsGroupBox;
        private System.Windows.Forms.CheckBox transactionViewCheckBox;
        private System.Windows.Forms.CheckBox employeeViewCheckBox;
        private System.Windows.Forms.CheckBox passwordCheckBox;
        private System.Windows.Forms.CheckBox transactionCheckBox;
        private System.Windows.Forms.CheckBox createUserCheckBox;
        private System.Windows.Forms.CheckBox changeProductsCheckBox;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Label label5;
    }
}