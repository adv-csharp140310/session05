namespace EFCodeFirst.UI
{
    partial class FormBlog
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
            groupBoxBlog = new GroupBox();
            SuspendLayout();
            // 
            // groupBoxBlog
            // 
            groupBoxBlog.Location = new Point(12, 12);
            groupBoxBlog.Name = "groupBoxBlog";
            groupBoxBlog.Size = new Size(532, 469);
            groupBoxBlog.TabIndex = 0;
            groupBoxBlog.TabStop = false;
            groupBoxBlog.Text = "Blog";
            // 
            // FormBlog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(879, 493);
            Controls.Add(groupBoxBlog);
            Name = "FormBlog";
            Text = "FormBlog";
            Load += FormBlog_Load;
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxBlog;
    }
}