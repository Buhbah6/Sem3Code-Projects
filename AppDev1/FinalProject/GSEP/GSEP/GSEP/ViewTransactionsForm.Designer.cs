namespace GSEP
{
    partial class ViewTransactionsForm
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
            System.Windows.Forms.Label transactionIDLabel;
            System.Windows.Forms.Label transactionDateLabel;
            System.Windows.Forms.Label totalLabel;
            System.Windows.Forms.Label employeeIDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewTransactionsForm));
            this.returnButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.transactionsDataSet = new GSEP.TransactionsDataSet();
            this.transactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionsTableAdapter = new GSEP.TransactionsDataSetTableAdapters.TransactionsTableAdapter();
            this.tableAdapterManager = new GSEP.TransactionsDataSetTableAdapters.TableAdapterManager();
            this.transactionsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.transactionIDTextBox = new System.Windows.Forms.TextBox();
            this.transactionDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.employeeIDTextBox = new System.Windows.Forms.TextBox();
            transactionIDLabel = new System.Windows.Forms.Label();
            transactionDateLabel = new System.Windows.Forms.Label();
            totalLabel = new System.Windows.Forms.Label();
            employeeIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingNavigator)).BeginInit();
            this.transactionsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // transactionIDLabel
            // 
            transactionIDLabel.AutoSize = true;
            transactionIDLabel.Font = new System.Drawing.Font("Sitka Banner", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            transactionIDLabel.Location = new System.Drawing.Point(52, 112);
            transactionIDLabel.Name = "transactionIDLabel";
            transactionIDLabel.Size = new System.Drawing.Size(193, 43);
            transactionIDLabel.TabIndex = 24;
            transactionIDLabel.Text = "Transaction ID:";
            // 
            // transactionDateLabel
            // 
            transactionDateLabel.AutoSize = true;
            transactionDateLabel.Font = new System.Drawing.Font("Sitka Banner", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            transactionDateLabel.Location = new System.Drawing.Point(25, 158);
            transactionDateLabel.Name = "transactionDateLabel";
            transactionDateLabel.Size = new System.Drawing.Size(219, 43);
            transactionDateLabel.TabIndex = 26;
            transactionDateLabel.Text = "Transaction Date:";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Font = new System.Drawing.Font("Sitka Banner", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            totalLabel.Location = new System.Drawing.Point(160, 203);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new System.Drawing.Size(84, 43);
            totalLabel.TabIndex = 28;
            totalLabel.Text = "Total:";
            // 
            // employeeIDLabel
            // 
            employeeIDLabel.AutoSize = true;
            employeeIDLabel.Font = new System.Drawing.Font("Sitka Banner", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            employeeIDLabel.Location = new System.Drawing.Point(69, 255);
            employeeIDLabel.Name = "employeeIDLabel";
            employeeIDLabel.Size = new System.Drawing.Size(172, 43);
            employeeIDLabel.TabIndex = 30;
            employeeIDLabel.Text = "Employee ID:";
            // 
            // returnButton
            // 
            this.returnButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.returnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnButton.Font = new System.Drawing.Font("Sitka Banner", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnButton.Location = new System.Drawing.Point(60, 343);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(573, 51);
            this.returnButton.TabIndex = 15;
            this.returnButton.Text = "Return to Menu";
            this.returnButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 57);
            this.label1.TabIndex = 16;
            this.label1.Text = "View Transactions";
            // 
            // transactionsDataSet
            // 
            this.transactionsDataSet.DataSetName = "TransactionsDataSet";
            this.transactionsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transactionsBindingSource
            // 
            this.transactionsBindingSource.DataMember = "Transactions";
            this.transactionsBindingSource.DataSource = this.transactionsDataSet;
            // 
            // transactionsTableAdapter
            // 
            this.transactionsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TransactionsTableAdapter = this.transactionsTableAdapter;
            this.tableAdapterManager.UpdateOrder = GSEP.TransactionsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // transactionsBindingNavigator
            // 
            this.transactionsBindingNavigator.AddNewItem = null;
            this.transactionsBindingNavigator.BindingSource = this.transactionsBindingSource;
            this.transactionsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.transactionsBindingNavigator.DeleteItem = null;
            this.transactionsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.transactionsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.transactionsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.transactionsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.transactionsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.transactionsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.transactionsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.transactionsBindingNavigator.Name = "transactionsBindingNavigator";
            this.transactionsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.transactionsBindingNavigator.Size = new System.Drawing.Size(691, 27);
            this.transactionsBindingNavigator.TabIndex = 17;
            this.transactionsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // transactionIDTextBox
            // 
            this.transactionIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.transactionIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transactionsBindingSource, "TransactionID", true));
            this.transactionIDTextBox.Location = new System.Drawing.Point(263, 126);
            this.transactionIDTextBox.Multiline = true;
            this.transactionIDTextBox.Name = "transactionIDTextBox";
            this.transactionIDTextBox.ReadOnly = true;
            this.transactionIDTextBox.Size = new System.Drawing.Size(379, 29);
            this.transactionIDTextBox.TabIndex = 25;
            // 
            // transactionDateDateTimePicker
            // 
            this.transactionDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.transactionsBindingSource, "TransactionDate", true));
            this.transactionDateDateTimePicker.Enabled = false;
            this.transactionDateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionDateDateTimePicker.Location = new System.Drawing.Point(263, 172);
            this.transactionDateDateTimePicker.Name = "transactionDateDateTimePicker";
            this.transactionDateDateTimePicker.Size = new System.Drawing.Size(379, 30);
            this.transactionDateDateTimePicker.TabIndex = 27;
            this.transactionDateDateTimePicker.Value = new System.DateTime(2021, 12, 4, 20, 4, 2, 0);
            // 
            // totalTextBox
            // 
            this.totalTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transactionsBindingSource, "Total", true));
            this.totalTextBox.Location = new System.Drawing.Point(263, 217);
            this.totalTextBox.Multiline = true;
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.ReadOnly = true;
            this.totalTextBox.Size = new System.Drawing.Size(379, 29);
            this.totalTextBox.TabIndex = 29;
            // 
            // employeeIDTextBox
            // 
            this.employeeIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.employeeIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transactionsBindingSource, "EmployeeID", true));
            this.employeeIDTextBox.Location = new System.Drawing.Point(263, 269);
            this.employeeIDTextBox.Multiline = true;
            this.employeeIDTextBox.Name = "employeeIDTextBox";
            this.employeeIDTextBox.ReadOnly = true;
            this.employeeIDTextBox.Size = new System.Drawing.Size(379, 29);
            this.employeeIDTextBox.TabIndex = 31;
            // 
            // ViewTransactionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 428);
            this.Controls.Add(transactionIDLabel);
            this.Controls.Add(this.transactionIDTextBox);
            this.Controls.Add(transactionDateLabel);
            this.Controls.Add(this.transactionDateDateTimePicker);
            this.Controls.Add(totalLabel);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(employeeIDLabel);
            this.Controls.Add(this.employeeIDTextBox);
            this.Controls.Add(this.transactionsBindingNavigator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.returnButton);
            this.Name = "ViewTransactionsForm";
            this.Text = "Transaction History";
            this.Load += new System.EventHandler(this.ViewTransactionsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transactionsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingNavigator)).EndInit();
            this.transactionsBindingNavigator.ResumeLayout(false);
            this.transactionsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Label label1;
        private TransactionsDataSet transactionsDataSet;
        private System.Windows.Forms.BindingSource transactionsBindingSource;
        private TransactionsDataSetTableAdapters.TransactionsTableAdapter transactionsTableAdapter;
        private TransactionsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator transactionsBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox transactionIDTextBox;
        private System.Windows.Forms.DateTimePicker transactionDateDateTimePicker;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.TextBox employeeIDTextBox;
    }
}