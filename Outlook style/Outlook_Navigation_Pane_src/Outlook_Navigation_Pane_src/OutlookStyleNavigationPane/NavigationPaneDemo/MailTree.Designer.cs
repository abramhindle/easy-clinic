namespace NavigationPaneDemo
{
    partial class MailTree
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MailTree));
            this.treeMailBox = new System.Windows.Forms.TreeView();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // treeMailBox
            // 
            this.treeMailBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeMailBox.ImageIndex = 0;
            this.treeMailBox.ImageList = this.ImageList;
            this.treeMailBox.Location = new System.Drawing.Point(0, 0);
            this.treeMailBox.Name = "treeMailBox";
            this.treeMailBox.SelectedImageIndex = 0;
            this.treeMailBox.ShowRootLines = false;
            this.treeMailBox.Size = new System.Drawing.Size(227, 234);
            this.treeMailBox.TabIndex = 0;
            // 
            // ImageList
            // 
            this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList.ImageStream")));
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList.Images.SetKeyName(0, "Drafts.bmp");
            this.ImageList.Images.SetKeyName(1, "Outbox.bmp");
            this.ImageList.Images.SetKeyName(2, "Recycle.bmp");
            this.ImageList.Images.SetKeyName(3, "Send.bmp");
            // 
            // MailTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeMailBox);
            this.Name = "MailTree";
            this.Size = new System.Drawing.Size(227, 234);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeMailBox;
        private System.Windows.Forms.ImageList ImageList;
    }
}
