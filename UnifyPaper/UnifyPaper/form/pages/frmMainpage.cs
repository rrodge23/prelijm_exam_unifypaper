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
    public partial class frmMainpage : Form
    {
        public frmMainpage()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void authrozationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form.pages.frmUsers fusr = new form.pages.frmUsers();
            fusr.ShowDialog();
        }

        private void frmMainpage_Load(object sender, EventArgs e)
        {
            lb.Text = Classes.session.userSession.username.ToString();
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            frmTransaction ft = new frmTransaction();
            ft.ShowDialog();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            frmCustomer fc = new frmCustomer();
            fc.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            frmDelete fd = new frmDelete();
            fd.ShowDialog();
        }

        private void btnReCall_Click(object sender, EventArgs e)
        {
            frmReCall fr = new frmReCall();
            fr.ShowDialog();
        }

        private void btnLookUp_Click(object sender, EventArgs e)
        {
            frmLookup fl = new frmLookup();
            fl.ShowDialog();
        }
    }
}
