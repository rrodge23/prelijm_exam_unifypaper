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
         


        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            loadSettings();
        }

        private void loadSettings()
        {

            lvUserList.Columns.Add("UID",250);
            lvUserList.Columns.Add("Username",250);
            lvUserList.Columns.Add("Role",250);
            ListViewItem lvUsers = new ListViewItem();

            lvUsers.Text = "1";
            lvUsers.SubItems.Add("asdf");
            lvUsers.SubItems.Add("asdf");
            
            lvUserList.Items.Add(lvUsers);
            buttonInit();
        }

        private Button buttonInit()
        {
            return new Button
            {
                FlatStyle = System.Windows.Forms.FlatStyle.System,
                Location = new System.Drawing.Point(935, 600),
                Name = "button",
                Size = new System.Drawing.Size(168, 24),
                TabIndex = 5,
                Text = "button"
            };
        }
        private void tpUserList_Click(object sender, EventArgs e)
        {
         
        }
    }
}
