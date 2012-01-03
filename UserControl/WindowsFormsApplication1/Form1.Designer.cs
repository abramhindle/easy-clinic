namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.collapsiblePanel2 = new OVT.CustomControls.CollapsiblePanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.collapsiblePanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // collapsiblePanel2
            // 
            this.collapsiblePanel2.BackColor = System.Drawing.Color.Transparent;
            this.collapsiblePanel2.Controls.Add(this.textBox1);
            this.collapsiblePanel2.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.collapsiblePanel2.HeaderImage = null;
            this.collapsiblePanel2.HeaderText = "CollapsiblePanel";
            this.collapsiblePanel2.HeaderTextColor = System.Drawing.Color.Black;
            this.collapsiblePanel2.Location = new System.Drawing.Point(30, 47);
            this.collapsiblePanel2.Name = "collapsiblePanel2";
            this.collapsiblePanel2.Size = new System.Drawing.Size(250, 150);
            this.collapsiblePanel2.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(53, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.collapsiblePanel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.collapsiblePanel2.ResumeLayout(false);
            this.collapsiblePanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private OVT.CustomControls.CollapsiblePanel collapsiblePanel2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

