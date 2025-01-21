using EFCodeFirst.Model;
using EFCodeFirst.UI;
using System.Windows.Forms;

namespace EFCodeFirst;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void buttonEnsureDB_Click(object sender, EventArgs e)
    {
        using var db = new AppDbBContext();
        db.Database.EnsureCreated();
    }

    private void buttonCreateUser_Click(object sender, EventArgs e)
    {
        using var db = new AppDbBContext();
        db.Users.Add(new User
        {
            FirstName = "Soroush",
            LastName = "Madani",
            Email = "nadrim",
            Password = "123",
            User_name = "Madani",
            IsActive = true
        });
        db.SaveChanges();
        MessageBox.Show("Done");
        loadData();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        loadData();
    }

    private void loadData()
    {
        using var db = new AppDbBContext();
        List<User> users = db.Users.ToList();
        dataGridView1.DataSource = null;
        dataGridView1.DataSource = users;
    }

    private void buttonLoadData_Click(object sender, EventArgs e)
    {
        loadData();
    }

    private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        var id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);
        if (dataGridView1.CurrentCell.OwningColumn.Name == "ColumnEdit")
        {
            using var db = new AppDbBContext();
            //var user = db.Users.Find(id); //Find, linq nist
            var user = db.Users.FirstOrDefault(x => x.Id == id);
            if (user != null)
            {
                user.User_name = "xyz";
                db.SaveChanges();
            }
        }

        if (dataGridView1.CurrentCell.OwningColumn.Name == "ColumnDelete")
        {
            using var db = new AppDbBContext();
            //var user = db.Users.Find(id); //Find, linq nist
            var user = db.Users.FirstOrDefault(x => x.Id == id);
            if (user != null)
            {
                db.Users.Remove(user);
                db.SaveChanges();
            }

        }

        loadData();
    }

    private void buttonBlog_Click(object sender, EventArgs e)
    {
        using var frm = new FormBlog();
        frm.ShowDialog();
    }
}
