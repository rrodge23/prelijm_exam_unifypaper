using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnifyPaper.Classes;

namespace UnifyPaper
{
    public partial class frmMainpage : Form
    {
        public frmMainpage()
        {
            InitializeComponent();
            tbPassword._TextBox.PasswordChar = '*';
        }

        Classes.database.database db = new Classes.database.database();

        private void tbUsername_OnTextChange(object sender, EventArgs e)
        {
            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            if(tbUsername.text.Length != 0 && tbPassword.text.Length != 0)
            {
                Classes.entities.users u = new Classes.entities.users();
                u.username = tbUsername.text.ToString().Trim();
                u.password = tbPassword.text.ToString().Trim();
                if (db.checkLogin(u))
                {
                    Classes.session.userSession.username = tbUsername.text.ToString();
                    Classes.session.userSession.password = tbPassword.text.ToString();
                    form.pages.frmMainpage frm = new form.pages.frmMainpage();
                    this.Hide();
                    frm.ShowDialog();
                    this.Close();
                }
                else {
                    MessageBox.Show("Invalid User Details");
                }
            }else{
                MessageBox.Show("Please Fill up All Details");
            }
        }
    }
}
