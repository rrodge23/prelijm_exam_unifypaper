using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnifyPaper.form.pages
{
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }

        private void lvUserList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem lv = new ListViewItem();


        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            Classes.entities.users u = new Classes.entities.users();
            lvUserList.Columns.Add("UID");
            lvUserList.Columns.Add("Username");
            lvUserList.Columns.Add("Role");
            lvUserList.Columns.Add("Date Created");

        }
    }
}
