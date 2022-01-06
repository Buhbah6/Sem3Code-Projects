namespace Assignment4
{
    partial class Form1
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.empIDTextBox = new System.Windows.Forms.TextBox();
            this.empNameTextBox = new System.Windows.Forms.TextBox();
            this.empSalaryTextBox = new System.Windows.Forms.TextBox();
            this.empAgeTextBox = new System.Windows.Forms.TextBox();
            this.previousRecordButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.nextRecordButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(107, 19);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(341, 32);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "JSON Employee Record";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Employee Age:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Employee Salary:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Employee Name:";
            // 
            // empIDTextBox
            // 
            this.empIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.empIDTextBox.Location = new System.Drawing.Point(237, 70);
            this.empIDTextBox.Name = "empIDTextBox";
            this.empIDTextBox.ReadOnly = true;
            this.empIDTextBox.Size = new System.Drawing.Size(301, 22);
            this.empIDTextBox.TabIndex = 5;
            // 
            // empNameTextBox
            // 
            this.empNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.empNameTextBox.Location = new System.Drawing.Point(237, 107);
            this.empNameTextBox.Name = "empNameTextBox";
            this.empNameTextBox.ReadOnly = true;
            this.empNameTextBox.Size = new System.Drawing.Size(301, 22);
            this.empNameTextBox.TabIndex = 6;
            // 
            // empSalaryTextBox
            // 
            this.empSalaryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.empSalaryTextBox.Location = new System.Drawing.Point(237, 146);
            this.empSalaryTextBox.Name = "empSalaryTextBox";
            this.empSalaryTextBox.ReadOnly = true;
            this.empSalaryTextBox.Size = new System.Drawing.Size(301, 22);
            this.empSalaryTextBox.TabIndex = 7;
            this.empSalaryTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // empAgeTextBox
            // 
            this.empAgeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.empAgeTextBox.Location = new System.Drawing.Point(237, 181);
            this.empAgeTextBox.Name = "empAgeTextBox";
            this.empAgeTextBox.ReadOnly = true;
            this.empAgeTextBox.Size = new System.Drawing.Size(301, 22);
            this.empAgeTextBox.TabIndex = 8;
            this.empAgeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // previousRecordButton
            // 
            this.previousRecordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previousRecordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousRecordButton.Location = new System.Drawing.Point(42, 236);
            this.previousRecordButton.Name = "previousRecordButton";
            this.previousRecordButton.Size = new System.Drawing.Size(121, 48);
            this.previousRecordButton.TabIndex = 9;
            this.previousRecordButton.Text = "Previous Record";
            this.previousRecordButton.UseVisualStyleBackColor = true;
            this.previousRecordButton.Click += new System.EventHandler(this.previousRecordButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(226, 236);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(121, 48);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // nextRecordButton
            // 
            this.nextRecordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextRecordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextRecordButton.Location = new System.Drawing.Point(417, 236);
            this.nextRecordButton.Name = "nextRecordButton";
            this.nextRecordButton.Size = new System.Drawing.Size(121, 48);
            this.nextRecordButton.TabIndex = 11;
            this.nextRecordButton.Text = "Next Record";
            this.nextRecordButton.UseVisualStyleBackColor = true;
            this.nextRecordButton.Click += new System.EventHandler(this.nextRecordButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 311);
            this.Controls.Add(this.nextRecordButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.previousRecordButton);
            this.Controls.Add(this.empAgeTextBox);
            this.Controls.Add(this.empSalaryTextBox);
            this.Controls.Add(this.empNameTextBox);
            this.Controls.Add(this.empIDTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "JSON RESTful API Employee Record Viewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox empIDTextBox;
        private System.Windows.Forms.TextBox empNameTextBox;
        private System.Windows.Forms.TextBox empSalaryTextBox;
        private System.Windows.Forms.TextBox empAgeTextBox;
        private System.Windows.Forms.Button previousRecordButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button nextRecordButton;
    }
}

