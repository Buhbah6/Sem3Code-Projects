
namespace ListView
{
    partial class ListViewTestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListViewTestForm));
            this.locationLabel = new System.Windows.Forms.Label();
            this.displayLabel = new System.Windows.Forms.Label();
            this.browserListView = new System.Windows.Forms.ListView();
            this.fileFolderImageList = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(17, 16);
            this.locationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(66, 17);
            this.locationLabel.TabIndex = 0;
            this.locationLabel.Text = "Location:";
            // 
            // displayLabel
            // 
            this.displayLabel.Location = new System.Drawing.Point(95, 11);
            this.displayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(676, 22);
            this.displayLabel.TabIndex = 1;
            // 
            // browserListView
            // 
            this.browserListView.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.browserListView.FullRowSelect = true;
            this.browserListView.HideSelection = false;
            this.browserListView.Location = new System.Drawing.Point(17, 37);
            this.browserListView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.browserListView.Name = "browserListView";
            this.browserListView.Size = new System.Drawing.Size(752, 282);
            this.browserListView.SmallImageList = this.fileFolderImageList;
            this.browserListView.View = System.Windows.Forms.View.List;
            this.browserListView.TabIndex = 2;
            this.browserListView.UseCompatibleStateImageBehavior = false;
            this.browserListView.Click += new System.EventHandler(this.browserListView_Click);
            // 
            // fileFolderImageList
            // 
            this.fileFolderImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("fileFolderImageList.ImageStream")));
            this.fileFolderImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.fileFolderImageList.Images.SetKeyName(0, "file.bmp");
            this.fileFolderImageList.Images.SetKeyName(1, "folder.bmp");
            // 
            // ListViewTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 335);
            this.Controls.Add(this.browserListView);
            this.Controls.Add(this.displayLabel);
            this.Controls.Add(this.locationLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ListViewTestForm";
            this.Text = "ListViewTest";
            this.Load += new System.EventHandler(this.ListViewTestForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label displayLabel;
        private System.Windows.Forms.ListView browserListView;
        private System.Windows.Forms.ImageList fileFolderImageList;
    }
}

