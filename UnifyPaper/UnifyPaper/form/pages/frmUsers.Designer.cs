namespace UnifyPaper.form.pages
{
    partial class frmUsers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsers));
            this.lvUserList = new System.Windows.Forms.ListView();
            this.tbSearchUser = new Bunifu.Framework.UI.BunifuTextbox();
            this.userCalendar = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lvUserList
            // 
            this.lvUserList.GridLines = true;
            this.lvUserList.Location = new System.Drawing.Point(26, 65);
            this.lvUserList.Name = "lvUserList";
            this.lvUserList.Size = new System.Drawing.Size(998, 324);
            this.lvUserList.TabIndex = 0;
            this.lvUserList.UseCompatibleStateImageBehavior = false;
            this.lvUserList.SelectedIndexChanged += new System.EventHandler(this.lvUserList_SelectedIndexChanged);
            // 
            // tbSearchUser
            // 
            this.tbSearchUser.BackColor = System.Drawing.Color.White;
            this.tbSearchUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbSearchUser.BackgroundImage")));
            this.tbSearchUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbSearchUser.ForeColor = System.Drawing.Color.Red;
            this.tbSearchUser.Icon = ((System.Drawing.Image)(resources.GetObject("tbSearchUser.Icon")));
            this.tbSearchUser.Location = new System.Drawing.Point(774, 17);
            this.tbSearchUser.Name = "tbSearchUser";
            this.tbSearchUser.Size = new System.Drawing.Size(250, 42);
            this.tbSearchUser.TabIndex = 1;
            this.tbSearchUser.text = "Search";
            // 
            // userCalendar
            // 
            this.userCalendar.Location = new System.Drawing.Point(26, 28);
            this.userCalendar.Name = "userCalendar";
            this.userCalendar.Size = new System.Drawing.Size(200, 20);
            this.userCalendar.TabIndex = 2;
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 486);
            this.Controls.Add(this.userCalendar);
            this.Controls.Add(this.tbSearchUser);
            this.Controls.Add(this.lvUserList);
            this.Name = "frmUsers";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmUsers_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvUserList;
        private Bunifu.Framework.UI.BunifuTextbox tbSearchUser;
        private System.Windows.Forms.DateTimePicker userCalendar;
    }
}