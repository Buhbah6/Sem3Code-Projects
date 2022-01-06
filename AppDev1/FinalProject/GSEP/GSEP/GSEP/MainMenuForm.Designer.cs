namespace GSEP
{
    partial class MainMenuForm
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
            this.createUsersButton = new System.Windows.Forms.Button();
            this.posButton = new System.Windows.Forms.Button();
            this.changePasswordButton = new System.Windows.Forms.Button();
            this.manageUsersButton = new System.Windows.Forms.Button();
            this.manageProductsButton = new System.Windows.Forms.Button();
            this.transactionViewButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.PaleGreen;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(655, 99);
            this.label1.TabIndex = 1;
            this.label1.Text = "Main Menu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // createUsersButton
            // 
            this.createUsersButton.BackColor = System.Drawing.Color.Gainsboro;
            this.createUsersButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.createUsersButton.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createUsersButton.ForeColor = System.Drawing.Color.Black;
            this.createUsersButton.Location = new System.Drawing.Point(61, 160);
            this.createUsersButton.Name = "createUsersButton";
            this.createUsersButton.Size = new System.Drawing.Size(287, 114);
            this.createUsersButton.TabIndex = 2;
            this.createUsersButton.Text = "Create Users";
            this.createUsersButton.UseVisualStyleBackColor = false;
            this.createUsersButton.Click += new System.EventHandler(this.createUsersButton_Click);
            // 
            // posButton
            // 
            this.posButton.BackColor = System.Drawing.Color.Gainsboro;
            this.posButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.posButton.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.posButton.ForeColor = System.Drawing.Color.Black;
            this.posButton.Location = new System.Drawing.Point(429, 160);
            this.posButton.Name = "posButton";
            this.posButton.Size = new System.Drawing.Size(287, 114);
            this.posButton.TabIndex = 3;
            this.posButton.Text = "Access POS";
            this.posButton.UseVisualStyleBackColor = false;
            this.posButton.Click += new System.EventHandler(this.posButton_Click);
            // 
            // changePasswordButton
            // 
            this.changePasswordButton.BackColor = System.Drawing.Color.Gainsboro;
            this.changePasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changePasswordButton.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePasswordButton.ForeColor = System.Drawing.Color.Black;
            this.changePasswordButton.Location = new System.Drawing.Point(429, 321);
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.Size = new System.Drawing.Size(287, 114);
            this.changePasswordButton.TabIndex = 4;
            this.changePasswordButton.Text = "Change Password";
            this.changePasswordButton.UseVisualStyleBackColor = false;
            this.changePasswordButton.Click += new System.EventHandler(this.changePasswordButton_Click);
            // 
            // manageUsersButton
            // 
            this.manageUsersButton.BackColor = System.Drawing.Color.Gainsboro;
            this.manageUsersButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.manageUsersButton.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageUsersButton.ForeColor = System.Drawing.Color.Black;
            this.manageUsersButton.Location = new System.Drawing.Point(61, 321);
            this.manageUsersButton.Name = "manageUsersButton";
            this.manageUsersButton.Size = new System.Drawing.Size(287, 114);
            this.manageUsersButton.TabIndex = 5;
            this.manageUsersButton.Text = "Manage Users";
            this.manageUsersButton.UseVisualStyleBackColor = false;
            this.manageUsersButton.Click += new System.EventHandler(this.manageUsersButton_Click);
            // 
            // manageProductsButton
            // 
            this.manageProductsButton.BackColor = System.Drawing.Color.Gainsboro;
            this.manageProductsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.manageProductsButton.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageProductsButton.ForeColor = System.Drawing.Color.Black;
            this.manageProductsButton.Location = new System.Drawing.Point(61, 481);
            this.manageProductsButton.Name = "manageProductsButton";
            this.manageProductsButton.Size = new System.Drawing.Size(287, 114);
            this.manageProductsButton.TabIndex = 6;
            this.manageProductsButton.Text = "View/Manage Products";
            this.manageProductsButton.UseVisualStyleBackColor = false;
            this.manageProductsButton.Click += new System.EventHandler(this.manageProductsButton_Click);
            // 
            // transactionViewButton
            // 
            this.transactionViewButton.BackColor = System.Drawing.Color.Gainsboro;
            this.transactionViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.transactionViewButton.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionViewButton.ForeColor = System.Drawing.Color.Black;
            this.transactionViewButton.Location = new System.Drawing.Point(429, 481);
            this.transactionViewButton.Name = "transactionViewButton";
            this.transactionViewButton.Size = new System.Drawing.Size(287, 114);
            this.transactionViewButton.TabIndex = 7;
            this.transactionViewButton.Text = "View Transactions";
            this.transactionViewButton.UseVisualStyleBackColor = false;
            this.transactionViewButton.Click += new System.EventHandler(this.transactionViewButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.Tomato;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logoutButton.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.ForeColor = System.Drawing.Color.White;
            this.logoutButton.Location = new System.Drawing.Point(61, 624);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(655, 67);
            this.logoutButton.TabIndex = 8;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(778, 726);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.transactionViewButton);
            this.Controls.Add(this.manageProductsButton);
            this.Controls.Add(this.manageUsersButton);
            this.Controls.Add(this.changePasswordButton);
            this.Controls.Add(this.posButton);
            this.Controls.Add(this.createUsersButton);
            this.Controls.Add(this.label1);
            this.Name = "MainMenuForm";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createUsersButton;
        private System.Windows.Forms.Button posButton;
        private System.Windows.Forms.Button changePasswordButton;
        private System.Windows.Forms.Button manageUsersButton;
        private System.Windows.Forms.Button manageProductsButton;
        private System.Windows.Forms.Button transactionViewButton;
        private System.Windows.Forms.Button logoutButton;
    }
}