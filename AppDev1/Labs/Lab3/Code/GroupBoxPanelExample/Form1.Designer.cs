
namespace GroupBoxPanelExample
{
    partial class GroupBoxPanelForm
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
            this.mainGroupBox = new System.Windows.Forms.GroupBox();
            this.hiButton = new System.Windows.Forms.Button();
            this.byeButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.leftButton = new System.Windows.Forms.Button();
            this.rightButton = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.mainGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainGroupBox
            // 
            this.mainGroupBox.Controls.Add(this.byeButton);
            this.mainGroupBox.Controls.Add(this.hiButton);
            this.mainGroupBox.Location = new System.Drawing.Point(23, 12);
            this.mainGroupBox.Name = "mainGroupBox";
            this.mainGroupBox.Size = new System.Drawing.Size(259, 69);
            this.mainGroupBox.TabIndex = 0;
            this.mainGroupBox.TabStop = false;
            this.mainGroupBox.Text = "Main GroupBox";
            // 
            // hiButton
            // 
            this.hiButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hiButton.Location = new System.Drawing.Point(7, 22);
            this.hiButton.Name = "hiButton";
            this.hiButton.Size = new System.Drawing.Size(126, 31);
            this.hiButton.TabIndex = 0;
            this.hiButton.Text = "Hi";
            this.hiButton.UseVisualStyleBackColor = true;
            this.hiButton.Click += new System.EventHandler(this.hiButton_Click);
            // 
            // byeButton
            // 
            this.byeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.byeButton.Location = new System.Drawing.Point(139, 22);
            this.byeButton.Name = "byeButton";
            this.byeButton.Size = new System.Drawing.Size(114, 32);
            this.byeButton.TabIndex = 1;
            this.byeButton.Text = "Bye";
            this.byeButton.UseVisualStyleBackColor = true;
            this.byeButton.Click += new System.EventHandler(this.byeButton_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rightButton);
            this.panel1.Controls.Add(this.leftButton);
            this.panel1.Location = new System.Drawing.Point(23, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 78);
            this.panel1.TabIndex = 1;
            // 
            // leftButton
            // 
            this.leftButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leftButton.Location = new System.Drawing.Point(4, 4);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(128, 35);
            this.leftButton.TabIndex = 0;
            this.leftButton.Text = "Far Left";
            this.leftButton.UseVisualStyleBackColor = true;
            this.leftButton.Click += new System.EventHandler(this.leftButton_Click);
            // 
            // rightButton
            // 
            this.rightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rightButton.Location = new System.Drawing.Point(396, 4);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(128, 35);
            this.rightButton.TabIndex = 1;
            this.rightButton.Text = "Far Right";
            this.rightButton.UseVisualStyleBackColor = true;
            this.rightButton.Click += new System.EventHandler(this.rightButton_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.messageLabel.Location = new System.Drawing.Point(23, 181);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(259, 23);
            this.messageLabel.TabIndex = 2;
            // 
            // GroupBoxPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 225);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainGroupBox);
            this.Name = "GroupBoxPanelForm";
            this.Text = "GroupBox and Panel";
            this.mainGroupBox.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mainGroupBox;
        private System.Windows.Forms.Button byeButton;
        private System.Windows.Forms.Button hiButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.Label messageLabel;
    }
}

