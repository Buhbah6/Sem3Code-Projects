
namespace DateTimePicker
{
    partial class DateTimePickerForm
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
            this.dropOffDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dodLabel = new System.Windows.Forms.Label();
            this.eddLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dropOffDateTimePicker
            // 
            this.dropOffDateTimePicker.Location = new System.Drawing.Point(12, 29);
            this.dropOffDateTimePicker.Name = "dropOffDateTimePicker";
            this.dropOffDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dropOffDateTimePicker.TabIndex = 0;
            this.dropOffDateTimePicker.ValueChanged += new System.EventHandler(this.dropOffDateTimePicker_ValueChanged);
            // 
            // dodLabel
            // 
            this.dodLabel.AutoSize = true;
            this.dodLabel.Location = new System.Drawing.Point(13, 13);
            this.dodLabel.Name = "dodLabel";
            this.dodLabel.Size = new System.Drawing.Size(76, 13);
            this.dodLabel.TabIndex = 1;
            this.dodLabel.Text = "Drop Off Date:";
            // 
            // eddLabel
            // 
            this.eddLabel.AutoSize = true;
            this.eddLabel.Location = new System.Drawing.Point(12, 56);
            this.eddLabel.Name = "eddLabel";
            this.eddLabel.Size = new System.Drawing.Size(123, 13);
            this.eddLabel.TabIndex = 2;
            this.eddLabel.Text = "Estimated Delivery Date:";
            // 
            // outputLabel
            // 
            this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.outputLabel.Location = new System.Drawing.Point(12, 73);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(200, 23);
            this.outputLabel.TabIndex = 3;
            // 
            // DateTimePickerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 107);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.eddLabel);
            this.Controls.Add(this.dodLabel);
            this.Controls.Add(this.dropOffDateTimePicker);
            this.Name = "DateTimePickerForm";
            this.Text = "DateTimePicker";
            this.Load += new System.EventHandler(this.DateTimePickerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dropOffDateTimePicker;
        private System.Windows.Forms.Label dodLabel;
        private System.Windows.Forms.Label eddLabel;
        private System.Windows.Forms.Label outputLabel;
    }
}

