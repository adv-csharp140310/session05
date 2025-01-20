using EFCodeFirst.Model;

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
        db.Users.Add(new User {FirstName = "Soroush", LastName = "Madani", Email = "nadrim", 
            Password ="123", UserName= "Madani", IsActive = true });
        db.SaveChanges();
        MessageBox.Show("Done");

        dataGridView1.DataSource = db.Users.ToList();
    }
}
