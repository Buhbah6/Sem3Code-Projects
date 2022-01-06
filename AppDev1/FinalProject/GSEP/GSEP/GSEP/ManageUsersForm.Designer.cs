namespace GSEP
{
    partial class ManageUsersForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label employeeIDLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label departmentLabel;
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.editNameButton = new System.Windows.Forms.Button();
            this.changeDeptButton = new System.Windows.Forms.Button();
            this.resetPassButton = new System.Windows.Forms.Button();
            this.updatePermsButton = new System.Windows.Forms.Button();
            this.deleteUserButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.empIDTextBox = new System.Windows.Forms.TextBox();
            this.fNameTextBox = new System.Windows.Forms.TextBox();
            this.lNameTextBox = new System.Windows.Forms.TextBox();
            this.depTextBox = new System.Windows.Forms.TextBox();
            this.menuButton = new System.Windows.Forms.Button();
            this.permsGroupBox = new System.Windows.Forms.GroupBox();
            this.transactionViewCheckBox = new System.Windows.Forms.CheckBox();
            this.changeProductsCheckBox = new System.Windows.Forms.CheckBox();
            this.createUserCheckBox = new System.Windows.Forms.CheckBox();
            this.employeeViewCheckBox = new System.Windows.Forms.CheckBox();
            this.transactionCheckBox = new System.Windows.Forms.CheckBox();
            this.passwordCheckBox = new System.Windows.Forms.CheckBox();
            this.employeesDataSet = new GSEP.EmployeesDataSet();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new GSEP.EmployeesDataSetTableAdapters.EmployeesTableAdapter();
            this.tableAdapterManager = new GSEP.EmployeesDataSetTableAdapters.TableAdapterManager();
            this.employeesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            employeeIDLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            departmentLabel = new System.Windows.Forms.Label();
            this.permsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeIDLabel
            // 
            employeeIDLabel.AutoSize = true;
            employeeIDLabel.Font = new System.Drawing.Font("Sitka Banner", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            employeeIDLabel.Location = new System.Drawing.Point(24, 144);
            employeeIDLabel.Name = "employeeIDLabel";
            employeeIDLabel.Size = new System.Drawing.Size(153, 39);
            employeeIDLabel.TabIndex = 42;
            employeeIDLabel.Text = "Employee ID:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new System.Drawing.Font("Sitka Banner", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            firstNameLabel.Location = new System.Drawing.Point(40, 183);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(137, 39);
            firstNameLabel.TabIndex = 46;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new System.Drawing.Font("Sitka Banner", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lastNameLabel.Location = new System.Drawing.Point(44, 222);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(133, 39);
            lastNameLabel.TabIndex = 48;
            lastNameLabel.Text = "Last Name:";
            // 
            // departmentLabel
            // 
            departmentLabel.AutoSize = true;
            departmentLabel.Font = new System.Drawing.Font("Sitka Banner", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            departmentLabel.Location = new System.Drawing.Point(29, 257);
            departmentLabel.Name = "departmentLabel";
            departmentLabel.Size = new System.Drawing.Size(148, 39);
            departmentLabel.TabIndex = 50;
            departmentLabel.Text = "Department:";
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsLabel.Location = new System.Drawing.Point(28, 107);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(667, 32);
            this.instructionsLabel.TabIndex = 42;
            this.instructionsLabel.Text = "Please enter an employee ID along with the information you want changed then pres" +
    "s the corresponding button.";
            this.instructionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // editNameButton
            // 
            this.editNameButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.editNameButton.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editNameButton.Location = new System.Drawing.Point(162, 310);
            this.editNameButton.Name = "editNameButton";
            this.editNameButton.Size = new System.Drawing.Size(131, 69);
            this.editNameButton.TabIndex = 41;
            this.editNameButton.Text = "Edit Name";
            this.editNameButton.UseVisualStyleBackColor = false;
            this.editNameButton.Click += new System.EventHandler(this.editNameButton_Click);
            // 
            // changeDeptButton
            // 
            this.changeDeptButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.changeDeptButton.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeDeptButton.Location = new System.Drawing.Point(299, 310);
            this.changeDeptButton.Name = "changeDeptButton";
            this.changeDeptButton.Size = new System.Drawing.Size(127, 69);
            this.changeDeptButton.TabIndex = 40;
            this.changeDeptButton.Text = "Change Department";
            this.changeDeptButton.UseVisualStyleBackColor = false;
            this.changeDeptButton.Click += new System.EventHandler(this.changeDeptButton_Click);
            // 
            // resetPassButton
            // 
            this.resetPassButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.resetPassButton.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetPassButton.Location = new System.Drawing.Point(28, 310);
            this.resetPassButton.Name = "resetPassButton";
            this.resetPassButton.Size = new System.Drawing.Size(128, 69);
            this.resetPassButton.TabIndex = 39;
            this.resetPassButton.Text = "Reset Password";
            this.resetPassButton.UseVisualStyleBackColor = false;
            this.resetPassButton.Click += new System.EventHandler(this.changePassButton_Click);
            // 
            // updatePermsButton
            // 
            this.updatePermsButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.updatePermsButton.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatePermsButton.Location = new System.Drawing.Point(455, 385);
            this.updatePermsButton.Name = "updatePermsButton";
            this.updatePermsButton.Size = new System.Drawing.Size(240, 43);
            this.updatePermsButton.TabIndex = 38;
            this.updatePermsButton.Text = "Update Permissions";
            this.updatePermsButton.UseVisualStyleBackColor = false;
            this.updatePermsButton.Click += new System.EventHandler(this.changePermsButton_Click);
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.deleteUserButton.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteUserButton.Location = new System.Drawing.Point(29, 385);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(397, 43);
            this.deleteUserButton.TabIndex = 37;
            this.deleteUserButton.Text = "Delete User";
            this.deleteUserButton.UseVisualStyleBackColor = false;
            this.deleteUserButton.Click += new System.EventHandler(this.deleteUserButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.titleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleLabel.Font = new System.Drawing.Font("Tahoma", 38F, System.Drawing.FontStyle.Underline);
            this.titleLabel.Location = new System.Drawing.Point(335, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(434, 79);
            this.titleLabel.TabIndex = 22;
            this.titleLabel.Text = "Manage Users";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // empIDTextBox
            // 
            this.empIDTextBox.Location = new System.Drawing.Point(187, 159);
            this.empIDTextBox.Name = "empIDTextBox";
            this.empIDTextBox.Size = new System.Drawing.Size(239, 22);
            this.empIDTextBox.TabIndex = 53;
            this.empIDTextBox.TextChanged += new System.EventHandler(this.empIDTextBox_TextChanged);
            // 
            // fNameTextBox
            // 
            this.fNameTextBox.Location = new System.Drawing.Point(187, 197);
            this.fNameTextBox.Name = "fNameTextBox";
            this.fNameTextBox.Size = new System.Drawing.Size(239, 22);
            this.fNameTextBox.TabIndex = 55;
            // 
            // lNameTextBox
            // 
            this.lNameTextBox.Location = new System.Drawing.Point(187, 235);
            this.lNameTextBox.Name = "lNameTextBox";
            this.lNameTextBox.Size = new System.Drawing.Size(239, 22);
            this.lNameTextBox.TabIndex = 56;
            // 
            // depTextBox
            // 
            this.depTextBox.Location = new System.Drawing.Point(187, 272);
            this.depTextBox.Name = "depTextBox";
            this.depTextBox.Size = new System.Drawing.Size(239, 22);
            this.depTextBox.TabIndex = 57;
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButton.Font = new System.Drawing.Font("Sitka Banner", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton.Location = new System.Drawing.Point(1023, 0);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(127, 38);
            this.menuButton.TabIndex = 60;
            this.menuButton.Text = "Return to Menu";
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
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
            this.permsGroupBox.Location = new System.Drawing.Point(456, 159);
            this.permsGroupBox.Name = "permsGroupBox";
            this.permsGroupBox.Size = new System.Drawing.Size(239, 220);
            this.permsGroupBox.TabIndex = 61;
            this.permsGroupBox.TabStop = false;
            this.permsGroupBox.Text = "Permissions";
            // 
            // transactionViewCheckBox
            // 
            this.transactionViewCheckBox.AutoSize = true;
            this.transactionViewCheckBox.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionViewCheckBox.Location = new System.Drawing.Point(6, 151);
            this.transactionViewCheckBox.Name = "transactionViewCheckBox";
            this.transactionViewCheckBox.Size = new System.Drawing.Size(175, 33);
            this.transactionViewCheckBox.TabIndex = 5;
            this.transactionViewCheckBox.Text = "View Transactions";
            this.transactionViewCheckBox.UseVisualStyleBackColor = true;
            // 
            // changeProductsCheckBox
            // 
            this.changeProductsCheckBox.AutoSize = true;
            this.changeProductsCheckBox.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeProductsCheckBox.Location = new System.Drawing.Point(6, 21);
            this.changeProductsCheckBox.Name = "changeProductsCheckBox";
            this.changeProductsCheckBox.Size = new System.Drawing.Size(206, 33);
            this.changeProductsCheckBox.TabIndex = 0;
            this.changeProductsCheckBox.Text = "Add/Remove Products";
            this.changeProductsCheckBox.UseVisualStyleBackColor = true;
            // 
            // createUserCheckBox
            // 
            this.createUserCheckBox.AutoSize = true;
            this.createUserCheckBox.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createUserCheckBox.Location = new System.Drawing.Point(6, 47);
            this.createUserCheckBox.Name = "createUserCheckBox";
            this.createUserCheckBox.Size = new System.Drawing.Size(130, 33);
            this.createUserCheckBox.TabIndex = 1;
            this.createUserCheckBox.Text = "Create Users";
            this.createUserCheckBox.UseVisualStyleBackColor = true;
            // 
            // employeeViewCheckBox
            // 
            this.employeeViewCheckBox.AutoSize = true;
            this.employeeViewCheckBox.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeViewCheckBox.Location = new System.Drawing.Point(6, 125);
            this.employeeViewCheckBox.Name = "employeeViewCheckBox";
            this.employeeViewCheckBox.Size = new System.Drawing.Size(160, 33);
            this.employeeViewCheckBox.TabIndex = 4;
            this.employeeViewCheckBox.Text = "View Employees";
            this.employeeViewCheckBox.UseVisualStyleBackColor = true;
            // 
            // transactionCheckBox
            // 
            this.transactionCheckBox.AutoSize = true;
            this.transactionCheckBox.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionCheckBox.Location = new System.Drawing.Point(6, 73);
            this.transactionCheckBox.Name = "transactionCheckBox";
            this.transactionCheckBox.Size = new System.Drawing.Size(209, 33);
            this.transactionCheckBox.TabIndex = 2;
            this.transactionCheckBox.Text = "Complete Transactions";
            this.transactionCheckBox.UseVisualStyleBackColor = true;
            // 
            // passwordCheckBox
            // 
            this.passwordCheckBox.AutoSize = true;
            this.passwordCheckBox.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordCheckBox.Location = new System.Drawing.Point(6, 99);
            this.passwordCheckBox.Name = "passwordCheckBox";
            this.passwordCheckBox.Size = new System.Drawing.Size(188, 33);
            this.passwordCheckBox.TabIndex = 3;
            this.passwordCheckBox.Text = "Generate Passwords";
            this.passwordCheckBox.UseVisualStyleBackColor = true;
            // 
            // employeesDataSet
            // 
            this.employeesDataSet.DataSetName = "EmployeesDataSet";
            this.employeesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.employeesDataSet;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmployeesTableAdapter = this.employeesTableAdapter;
            this.tableAdapterManager.UpdateOrder = GSEP.EmployeesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // employeesDataGridView
            // 
            this.employeesDataGridView.AutoGenerateColumns = false;
            this.employeesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.employeesDataGridView.DataSource = this.employeesBindingSource;
            this.employeesDataGridView.Location = new System.Drawing.Point(718, 107);
            this.employeesDataGridView.Name = "employeesDataGridView";
            this.employeesDataGridView.ReadOnly = true;
            this.employeesDataGridView.RowHeadersWidth = 51;
            this.employeesDataGridView.RowTemplate.Height = 24;
            this.employeesDataGridView.Size = new System.Drawing.Size(413, 321);
            this.employeesDataGridView.TabIndex = 62;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "EmployeeID";
            this.dataGridViewTextBoxColumn1.HeaderText = "EmployeeID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn3.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn4.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Department";
            this.dataGridViewTextBoxColumn5.HeaderText = "Department";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Permissions";
            this.dataGridViewTextBoxColumn6.HeaderText = "Permissions";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // ManageUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1151, 446);
            this.Controls.Add(this.employeesDataGridView);
            this.Controls.Add(this.permsGroupBox);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.depTextBox);
            this.Controls.Add(this.lNameTextBox);
            this.Controls.Add(this.fNameTextBox);
            this.Controls.Add(this.updatePermsButton);
            this.Controls.Add(this.empIDTextBox);
            this.Controls.Add(employeeIDLabel);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(departmentLabel);
            this.Controls.Add(this.instructionsLabel);
            this.Controls.Add(this.editNameButton);
            this.Controls.Add(this.changeDeptButton);
            this.Controls.Add(this.resetPassButton);
            this.Controls.Add(this.deleteUserButton);
            this.Controls.Add(this.titleLabel);
            this.Name = "ManageUsersForm";
            this.Text = "Manage Users";
            this.Load += new System.EventHandler(this.ManageUsersForm_Load);
            this.permsGroupBox.ResumeLayout(false);
            this.permsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.Button editNameButton;
        private System.Windows.Forms.Button changeDeptButton;
        private System.Windows.Forms.Button resetPassButton;
        private System.Windows.Forms.Button updatePermsButton;
        private System.Windows.Forms.Button deleteUserButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox empIDTextBox;
        private System.Windows.Forms.TextBox fNameTextBox;
        private System.Windows.Forms.TextBox lNameTextBox;
        private System.Windows.Forms.TextBox depTextBox;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.GroupBox permsGroupBox;
        private System.Windows.Forms.CheckBox transactionViewCheckBox;
        private System.Windows.Forms.CheckBox changeProductsCheckBox;
        private System.Windows.Forms.CheckBox createUserCheckBox;
        private System.Windows.Forms.CheckBox employeeViewCheckBox;
        private System.Windows.Forms.CheckBox transactionCheckBox;
        private System.Windows.Forms.CheckBox passwordCheckBox;
        private EmployeesDataSet employeesDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private EmployeesDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private EmployeesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView employeesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}