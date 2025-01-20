using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFDbFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //create db context
            // db.User().Where.ToList()

            using (var db = new cs140310Entities())
            {
                /*
                 * MyFunc(User u) {return u.IsActive == true;}
                 * (User x) => {return  x.IsActive == true;}
                 * (x) => {return  x.IsActive == true;}
                 * x => x.IsActive == true
                 */
                //Lazy 
                //E
                dataGridViewUsers.DataSource = db.Users
                    .Where(u => u.IsActive == true)
                    .OrderBy(u => u.FirstName)
                    .ToList();
            }
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            using (var db = new cs140310Entities())
            {
                var user = new User { IsActive = true, FirstName = "Samira", Family = "Mohsenzadeh", Email = "N/A" };
                db.Users.Add(user);
                //db.Users.Add(user2);
                //db.Products.Add(new Product { Name = "PC", Price = 5000, IsActive = true});
                db.SaveChanges();
            }
        }
    }
}
