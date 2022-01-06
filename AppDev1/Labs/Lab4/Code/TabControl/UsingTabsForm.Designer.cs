
namespace TabControl
{
    partial class UsingTabsForm
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.colorTabPage = new System.Windows.Forms.TabPage();
            this.greenRadioButton = new System.Windows.Forms.RadioButton();
            this.redRadioButton = new System.Windows.Forms.RadioButton();
            this.blackRadioButton = new System.Windows.Forms.RadioButton();
            this.sizeTabPage = new System.Windows.Forms.TabPage();
            this.size20RadioButton = new System.Windows.Forms.RadioButton();
            this.size16RadioButton = new System.Windows.Forms.RadioButton();
            this.size12RadioButton = new System.Windows.Forms.RadioButton();
            this.messageTabPage = new System.Windows.Forms.TabPage();
            this.goodbyeRadioButton = new System.Windows.Forms.RadioButton();
            this.helloRadioButton = new System.Windows.Forms.RadioButton();
            this.aboutTabPage = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.displayLabel = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.colorTabPage.SuspendLayout();
            this.sizeTabPage.SuspendLayout();
            this.messageTabPage.SuspendLayout();
            this.aboutTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.colorTabPage);
            this.tabControl.Controls.Add(this.sizeTabPage);
            this.tabControl.Controls.Add(this.messageTabPage);
            this.tabControl.Controls.Add(this.aboutTabPage);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(253, 129);
            this.tabControl.TabIndex = 0;
            // 
            // colorTabPage
            // 
            this.colorTabPage.Controls.Add(this.greenRadioButton);
            this.colorTabPage.Controls.Add(this.redRadioButton);
            this.colorTabPage.Controls.Add(this.blackRadioButton);
            this.colorTabPage.Location = new System.Drawing.Point(4, 25);
            this.colorTabPage.Name = "colorTabPage";
            this.colorTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.colorTabPage.Size = new System.Drawing.Size(245, 100);
            this.colorTabPage.TabIndex = 0;
            this.colorTabPage.Text = "Color";
            this.colorTabPage.UseVisualStyleBackColor = true;
            // 
            // greenRadioButton
            // 
            this.greenRadioButton.AutoSize = true;
            this.greenRadioButton.Location = new System.Drawing.Point(7, 61);
            this.greenRadioButton.Name = "greenRadioButton";
            this.greenRadioButton.Size = new System.Drawing.Size(69, 21);
            this.greenRadioButton.TabIndex = 2;
            this.greenRadioButton.TabStop = true;
            this.greenRadioButton.Text = "Green";
            this.greenRadioButton.UseVisualStyleBackColor = true;
            this.greenRadioButton.CheckedChanged += new System.EventHandler(this.greenRadioButton_CheckedChanged);
            // 
            // redRadioButton
            // 
            this.redRadioButton.AutoSize = true;
            this.redRadioButton.Location = new System.Drawing.Point(7, 34);
            this.redRadioButton.Name = "redRadioButton";
            this.redRadioButton.Size = new System.Drawing.Size(55, 21);
            this.redRadioButton.TabIndex = 1;
            this.redRadioButton.TabStop = true;
            this.redRadioButton.Text = "Red";
            this.redRadioButton.UseVisualStyleBackColor = true;
            this.redRadioButton.CheckedChanged += new System.EventHandler(this.redRadioButton_CheckedChanged);
            // 
            // blackRadioButton
            // 
            this.blackRadioButton.AutoSize = true;
            this.blackRadioButton.Location = new System.Drawing.Point(7, 7);
            this.blackRadioButton.Name = "blackRadioButton";
            this.blackRadioButton.Size = new System.Drawing.Size(63, 21);
            this.blackRadioButton.TabIndex = 0;
            this.blackRadioButton.TabStop = true;
            this.blackRadioButton.Text = "Black";
            this.blackRadioButton.UseVisualStyleBackColor = true;
            this.blackRadioButton.CheckedChanged += new System.EventHandler(this.blackRadioButton_CheckedChanged);
            // 
            // sizeTabPage
            // 
            this.sizeTabPage.Controls.Add(this.size20RadioButton);
            this.sizeTabPage.Controls.Add(this.size16RadioButton);
            this.sizeTabPage.Controls.Add(this.size12RadioButton);
            this.sizeTabPage.Location = new System.Drawing.Point(4, 25);
            this.sizeTabPage.Name = "sizeTabPage";
            this.sizeTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.sizeTabPage.Size = new System.Drawing.Size(245, 100);
            this.sizeTabPage.TabIndex = 1;
            this.sizeTabPage.Text = "Size";
            this.sizeTabPage.UseVisualStyleBackColor = true;
            // 
            // size20RadioButton
            // 
            this.size20RadioButton.AutoSize = true;
            this.size20RadioButton.Location = new System.Drawing.Point(7, 61);
            this.size20RadioButton.Name = "size20RadioButton";
            this.size20RadioButton.Size = new System.Drawing.Size(80, 21);
            this.size20RadioButton.TabIndex = 2;
            this.size20RadioButton.TabStop = true;
            this.size20RadioButton.Text = "20 point";
            this.size20RadioButton.UseVisualStyleBackColor = true;
            this.size20RadioButton.CheckedChanged += new System.EventHandler(this.size20RadioButton_CheckedChanged);
            // 
            // size16RadioButton
            // 
            this.size16RadioButton.AutoSize = true;
            this.size16RadioButton.Location = new System.Drawing.Point(7, 34);
            this.size16RadioButton.Name = "size16RadioButton";
            this.size16RadioButton.Size = new System.Drawing.Size(80, 21);
            this.size16RadioButton.TabIndex = 1;
            this.size16RadioButton.TabStop = true;
            this.size16RadioButton.Text = "16 point";
            this.size16RadioButton.UseVisualStyleBackColor = true;
            this.size16RadioButton.CheckedChanged += new System.EventHandler(this.size16RadioButton_CheckedChanged);
            // 
            // size12RadioButton
            // 
            this.size12RadioButton.AutoSize = true;
            this.size12RadioButton.Location = new System.Drawing.Point(7, 7);
            this.size12RadioButton.Name = "size12RadioButton";
            this.size12RadioButton.Size = new System.Drawing.Size(80, 21);
            this.size12RadioButton.TabIndex = 0;
            this.size12RadioButton.TabStop = true;
            this.size12RadioButton.Text = "12 point";
            this.size12RadioButton.UseVisualStyleBackColor = true;
            this.size12RadioButton.CheckedChanged += new System.EventHandler(this.size12RadioButton_CheckedChanged);
            // 
            // messageTabPage
            // 
            this.messageTabPage.Controls.Add(this.goodbyeRadioButton);
            this.messageTabPage.Controls.Add(this.helloRadioButton);
            this.messageTabPage.Location = new System.Drawing.Point(4, 25);
            this.messageTabPage.Name = "messageTabPage";
            this.messageTabPage.Size = new System.Drawing.Size(245, 100);
            this.messageTabPage.TabIndex = 2;
            this.messageTabPage.Text = "Message";
            this.messageTabPage.UseVisualStyleBackColor = true;
            // 
            // goodbyeRadioButton
            // 
            this.goodbyeRadioButton.AutoSize = true;
            this.goodbyeRadioButton.Location = new System.Drawing.Point(4, 31);
            this.goodbyeRadioButton.Name = "goodbyeRadioButton";
            this.goodbyeRadioButton.Size = new System.Drawing.Size(90, 21);
            this.goodbyeRadioButton.TabIndex = 1;
            this.goodbyeRadioButton.TabStop = true;
            this.goodbyeRadioButton.Text = "Goodbye!";
            this.goodbyeRadioButton.UseVisualStyleBackColor = true;
            this.goodbyeRadioButton.CheckedChanged += new System.EventHandler(this.goodbyeRadioButton_CheckedChanged);
            // 
            // helloRadioButton
            // 
            this.helloRadioButton.AutoSize = true;
            this.helloRadioButton.Location = new System.Drawing.Point(4, 4);
            this.helloRadioButton.Name = "helloRadioButton";
            this.helloRadioButton.Size = new System.Drawing.Size(64, 21);
            this.helloRadioButton.TabIndex = 0;
            this.helloRadioButton.TabStop = true;
            this.helloRadioButton.Text = "Hello!";
            this.helloRadioButton.UseVisualStyleBackColor = true;
            this.helloRadioButton.CheckedChanged += new System.EventHandler(this.helloRadioButton_CheckedChanged);
            // 
            // aboutTabPage
            // 
            this.aboutTabPage.Controls.Add(this.label1);
            this.aboutTabPage.Location = new System.Drawing.Point(4, 25);
            this.aboutTabPage.Name = "aboutTabPage";
            this.aboutTabPage.Size = new System.Drawing.Size(245, 100);
            this.aboutTabPage.TabIndex = 3;
            this.aboutTabPage.Text = "About";
            this.aboutTabPage.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 96);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tabs are used to organize controls and conserve screen space";
            // 
            // displayLabel
            // 
            this.displayLabel.Location = new System.Drawing.Point(16, 144);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(245, 52);
            this.displayLabel.TabIndex = 1;
            // 
            // UsingTabsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 205);
            this.Controls.Add(this.displayLabel);
            this.Controls.Add(this.tabControl);
            this.Name = "UsingTabsForm";
            this.Text = "Using Tabs";
            this.tabControl.ResumeLayout(false);
            this.colorTabPage.ResumeLayout(false);
            this.colorTabPage.PerformLayout();
            this.sizeTabPage.ResumeLayout(false);
            this.sizeTabPage.PerformLayout();
            this.messageTabPage.ResumeLayout(false);
            this.messageTabPage.PerformLayout();
            this.aboutTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage colorTabPage;
        private System.Windows.Forms.TabPage sizeTabPage;
        private System.Windows.Forms.TabPage messageTabPage;
        private System.Windows.Forms.TabPage aboutTabPage;
        private System.Windows.Forms.RadioButton greenRadioButton;
        private System.Windows.Forms.RadioButton redRadioButton;
        private System.Windows.Forms.RadioButton blackRadioButton;
        private System.Windows.Forms.RadioButton size20RadioButton;
        private System.Windows.Forms.RadioButton size16RadioButton;
        private System.Windows.Forms.RadioButton size12RadioButton;
        private System.Windows.Forms.RadioButton goodbyeRadioButton;
        private System.Windows.Forms.RadioButton helloRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label displayLabel;
    }
}

