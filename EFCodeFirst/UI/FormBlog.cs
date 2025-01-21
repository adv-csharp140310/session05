using EFCodeFirst.Model;
using session05.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFCodeFirst.UI
{
    public partial class FormBlog : Form
    {
        public FormBlog()
        {
            InitializeComponent();
        }

        private void FormBlog_Load(object sender, EventArgs e)
        {
            groupBoxBlog.DesignForm(typeof(Blog));
        }
    }
}
