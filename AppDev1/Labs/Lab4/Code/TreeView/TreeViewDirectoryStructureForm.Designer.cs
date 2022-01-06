
namespace TreeView
{
    partial class TreeViewDirectoryStructureForm
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
            this.directoryTreeView = new System.Windows.Forms.TreeView();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // directoryTreeView
            // 
            this.directoryTreeView.Location = new System.Drawing.Point(20, 63);
            this.directoryTreeView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.directoryTreeView.Name = "directoryTreeView";
            this.directoryTreeView.Size = new System.Drawing.Size(359, 288);
            this.directoryTreeView.TabIndex = 0;
            // 
            // inputTextBox
            // 
            this.inputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputTextBox.Location = new System.Drawing.Point(20, 31);
            this.inputTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(219, 22);
            this.inputTextBox.TabIndex = 1;
            // 
            // enterButton
            // 
            this.enterButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.enterButton.Location = new System.Drawing.Point(248, 31);
            this.enterButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(132, 25);
            this.enterButton.TabIndex = 2;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(16, 11);
            this.messageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(362, 17);
            this.messageLabel.TabIndex = 3;
            this.messageLabel.Text = "Enter the full path to the directory you would like to view:";
            // 
            // TreeViewDirectoryStructureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 364);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.directoryTreeView);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TreeViewDirectoryStructureForm";
            this.Text = "TreeView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView directoryTreeView;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Label messageLabel;
    }
}

