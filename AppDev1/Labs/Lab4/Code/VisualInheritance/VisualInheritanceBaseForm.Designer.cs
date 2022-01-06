
namespace VisualInheritance
{
    partial class VisualInheritanceBaseForm
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
            this.bugsLabel = new System.Windows.Forms.Label();
            this.learnMoreButton = new System.Windows.Forms.Button();
            this.copyrightLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bugsLabel
            // 
            this.bugsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bugsLabel.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bugsLabel.Location = new System.Drawing.Point(12, 9);
            this.bugsLabel.Name = "bugsLabel";
            this.bugsLabel.Size = new System.Drawing.Size(381, 68);
            this.bugsLabel.TabIndex = 0;
            this.bugsLabel.Text = "Bugs, Bugs, Bugs";
            this.bugsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // learnMoreButton
            // 
            this.learnMoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.learnMoreButton.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.learnMoreButton.Location = new System.Drawing.Point(12, 94);
            this.learnMoreButton.Name = "learnMoreButton";
            this.learnMoreButton.Size = new System.Drawing.Size(179, 64);
            this.learnMoreButton.TabIndex = 1;
            this.learnMoreButton.Text = "Learn More";
            this.learnMoreButton.UseVisualStyleBackColor = true;
            this.learnMoreButton.Click += new System.EventHandler(this.learnMoreButton_Click);
            // 
            // copyrightLabel
            // 
            this.copyrightLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.copyrightLabel.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyrightLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.copyrightLabel.Location = new System.Drawing.Point(13, 174);
            this.copyrightLabel.Name = "copyrightLabel";
            this.copyrightLabel.Size = new System.Drawing.Size(380, 23);
            this.copyrightLabel.TabIndex = 2;
            this.copyrightLabel.Text = "Copyright 2017, by Deitel & Associates, Inc.";
            this.copyrightLabel.UseMnemonic = false;
            // 
            // VisualInheritanceBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 215);
            this.Controls.Add(this.copyrightLabel);
            this.Controls.Add(this.learnMoreButton);
            this.Controls.Add(this.bugsLabel);
            this.Name = "VisualInheritanceBaseForm";
            this.Text = "Visual Inheritance Base";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label bugsLabel;
        private System.Windows.Forms.Button learnMoreButton;
        private System.Windows.Forms.Label copyrightLabel;
    }
}

