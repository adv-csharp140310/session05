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
        ColumnEdit = new DataGridViewButtonColumn();
        ColumnDelete = new DataGridViewButtonColumn();
        buttonLoadData = new Button();
        buttonBlog = new Button();
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
        dataGridView1.AllowUserToAddRows = false;
        dataGridView1.AllowUserToDeleteRows = false;
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnEdit, ColumnDelete });
        dataGridView1.Location = new Point(12, 81);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.ReadOnly = true;
        dataGridView1.Size = new Size(776, 357);
        dataGridView1.TabIndex = 2;
        dataGridView1.CellClick += dataGridView1_CellClick;
        // 
        // ColumnEdit
        // 
        ColumnEdit.HeaderText = "Edit";
        ColumnEdit.Name = "ColumnEdit";
        ColumnEdit.ReadOnly = true;
        ColumnEdit.Text = "Edit";
        ColumnEdit.UseColumnTextForButtonValue = true;
        // 
        // ColumnDelete
        // 
        ColumnDelete.HeaderText = "Delete";
        ColumnDelete.Name = "ColumnDelete";
        ColumnDelete.ReadOnly = true;
        ColumnDelete.Text = "Delete";
        ColumnDelete.UseColumnTextForButtonValue = true;
        // 
        // buttonLoadData
        // 
        buttonLoadData.Location = new Point(704, 41);
        buttonLoadData.Name = "buttonLoadData";
        buttonLoadData.Size = new Size(75, 23);
        buttonLoadData.TabIndex = 3;
        buttonLoadData.Text = "Load Data";
        buttonLoadData.UseVisualStyleBackColor = true;
        buttonLoadData.Click += buttonLoadData_Click;
        // 
        // buttonBlog
        // 
        buttonBlog.Location = new Point(623, 41);
        buttonBlog.Name = "buttonBlog";
        buttonBlog.Size = new Size(75, 23);
        buttonBlog.TabIndex = 4;
        buttonBlog.Text = "Blog";
        buttonBlog.UseVisualStyleBackColor = true;
        buttonBlog.Click += buttonBlog_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(buttonBlog);
        Controls.Add(buttonLoadData);
        Controls.Add(dataGridView1);
        Controls.Add(buttonCreateUser);
        Controls.Add(buttonEnsureDB);
        Name = "Form1";
        Text = "Form1";
        Load += Form1_Load;
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Button buttonEnsureDB;
    private Button buttonCreateUser;
    private DataGridView dataGridView1;
    private DataGridViewButtonColumn ColumnEdit;
    private DataGridViewButtonColumn ColumnDelete;
    private Button buttonLoadData;
    private Button buttonBlog;
}
