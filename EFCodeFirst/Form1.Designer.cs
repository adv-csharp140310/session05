namespace EFCodeFirst;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        buttonEnsureDB = new Button();
        buttonCreateUser = new Button();
        dataGridView1 = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // buttonEnsureDB
        // 
        buttonEnsureDB.Location = new Point(12, 12);
        buttonEnsureDB.Name = "buttonEnsureDB";
        buttonEnsureDB.Size = new Size(133, 23);
        buttonEnsureDB.TabIndex = 0;
        buttonEnsureDB.Text = "Ensure DB";
        buttonEnsureDB.UseVisualStyleBackColor = true;
        buttonEnsureDB.Click += buttonEnsureDB_Click;
        // 
        // buttonCreateUser
        // 
        buttonCreateUser.Location = new Point(12, 41);
        buttonCreateUser.Name = "buttonCreateUser";
        buttonCreateUser.Size = new Size(133, 23);
        buttonCreateUser.TabIndex = 1;
        buttonCreateUser.Text = "Create User";
        buttonCreateUser.UseVisualStyleBackColor = true;
        buttonCreateUser.Click += buttonCreateUser_Click;
        // 
        // dataGridView1
        // 
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Location = new Point(12, 81);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.Size = new Size(776, 357);
        dataGridView1.TabIndex = 2;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(dataGridView1);
        Controls.Add(buttonCreateUser);
        Controls.Add(buttonEnsureDB);
        Name = "Form1";
        Text = "Form1";
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Button buttonEnsureDB;
    private Button buttonCreateUser;
    private DataGridView dataGridView1;
}
