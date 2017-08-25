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
            this.tbSearchUser = new Bunifu.Framework.UI.BunifuTextbox();
            this.userCalendar = new System.Windows.Forms.DateTimePicker();
            this.tpTableUserList = new System.Windows.Forms.TabPage();
            this.tpUserList = new System.Windows.Forms.TabPage();
            this.lvUserList = new System.Windows.Forms.ListView();
            this.tpAddNewUser = new System.Windows.Forms.TabControl();
            this.tpUserList.SuspendLayout();
            this.tpAddNewUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbSearchUser
            // 
            this.tbSearchUser.BackColor = System.Drawing.Color.White;
            this.tbSearchUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbSearchUser.BackgroundImage")));
            this.tbSearchUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbSearchUser.ForeColor = System.Drawing.Color.Red;
            this.tbSearchUser.Icon = ((System.Drawing.Image)(resources.GetObject("tbSearchUser.Icon")));
            this.tbSearchUser.Location = new System.Drawing.Point(774, 28);
            this.tbSearchUser.Name = "tbSearchUser";
            this.tbSearchUser.Size = new System.Drawing.Size(250, 31);
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
            // tpTableUserList
            // 
            this.tpTableUserList.Location = new System.Drawing.Point(4, 22);
            this.tpTableUserList.Name = "tpTableUserList";
            this.tpTableUserList.Padding = new System.Windows.Forms.Padding(3);
            this.tpTableUserList.Size = new System.Drawing.Size(990, 326);
            this.tpTableUserList.TabIndex = 1;
            this.tpTableUserList.Text = "Add User";
            this.tpTableUserList.UseVisualStyleBackColor = true;
            // 
            // tpUserList
            // 
            this.tpUserList.Controls.Add(this.lvUserList);
            this.tpUserList.Location = new System.Drawing.Point(4, 22);
            this.tpUserList.Name = "tpUserList";
            this.tpUserList.Padding = new System.Windows.Forms.Padding(3);
            this.tpUserList.Size = new System.Drawing.Size(990, 326);
            this.tpUserList.TabIndex = 0;
            this.tpUserList.Text = "List";
            this.tpUserList.UseVisualStyleBackColor = true;
            this.tpUserList.Click += new System.EventHandler(this.tpUserList_Click);
            // 
            // lvUserList
            // 
            this.lvUserList.GridLines = true;
            this.lvUserList.Location = new System.Drawing.Point(0, 0);
            this.lvUserList.Name = "lvUserList";
            this.lvUserList.Size = new System.Drawing.Size(990, 326);
            this.lvUserList.TabIndex = 1;
            this.lvUserList.UseCompatibleStateImageBehavior = false;
            this.lvUserList.View = System.Windows.Forms.View.Details;
            // 
            // tpAddNewUser
            // 
            this.tpAddNewUser.Controls.Add(this.tpUserList);
            this.tpAddNewUser.Controls.Add(this.tpTableUserList);
            this.tpAddNewUser.Location = new System.Drawing.Point(26, 65);
            this.tpAddNewUser.Name = "tpAddNewUser";
            this.tpAddNewUser.SelectedIndex = 0;
            this.tpAddNewUser.Size = new System.Drawing.Size(998, 352);
            this.tpAddNewUser.TabIndex = 3;
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 486);
            this.Controls.Add(this.tpAddNewUser);
            this.Controls.Add(this.userCalendar);
            this.Controls.Add(this.tbSearchUser);
            this.Name = "frmUsers";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmUsers_Load);
            this.tpUserList.ResumeLayout(false);
            this.tpAddNewUser.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuTextbox tbSearchUser;
        private System.Windows.Forms.DateTimePicker userCalendar;
        private System.Windows.Forms.TabPage tpTableUserList;
        private System.Windows.Forms.TabPage tpUserList;
        private System.Windows.Forms.ListView lvUserList;
        private System.Windows.Forms.TabControl tpAddNewUser;
    }
}