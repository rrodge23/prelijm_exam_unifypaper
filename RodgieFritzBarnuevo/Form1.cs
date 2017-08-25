using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RodgieFritzBarnuevo.Classes;


namespace RodgieFritzBarnuevo
{
    public partial class frmMain : Form
    {
       

        public frmMain()
        {         
            InitializeComponent();
            tbPassword.PasswordChar = '*';
        }
        Database db = new Database();
        
        private void lvlItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text.Length > 0 && tbPassword.Text.Length > 0)
            {
                authLogin();
            }
            else
            {
                MessageBox.Show("Please Fill Up All Fields");
            }
            
        }

        public void authLogin() 
        {
            user u = new user();
            u.username = tbUsername.Text;
            u.password = tbPassword.Text;
            if (db.checkAuth(u) == true)
            {
                MessageBox.Show("success");
            }
            else
            {
                MessageBox.Show("failed");
            }
            
        }
    
        private void frmMain_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

     
    }
}
