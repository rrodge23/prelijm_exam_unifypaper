namespace UnifyPaper
{
    partial class frmMainpage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainpage));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.tbUsername = new Bunifu.Framework.UI.BunifuTextbox();
            this.tbPassword = new Bunifu.Framework.UI.BunifuTextbox();
            this.btnLogin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnLog = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.btnClose);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.WhiteSmoke;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Red;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1420, 34);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnClose.InitialImage")));
            this.btnClose.Location = new System.Drawing.Point(1375, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 34);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 1;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tbUsername
            // 
            this.tbUsername.BackColor = System.Drawing.Color.Silver;
            this.tbUsername.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbUsername.BackgroundImage")));
            this.tbUsername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbUsername.ForeColor = System.Drawing.Color.SeaShell;
            this.tbUsername.Icon = ((System.Drawing.Image)(resources.GetObject("tbUsername.Icon")));
            this.tbUsername.Location = new System.Drawing.Point(1032, 119);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(333, 52);
            this.tbUsername.TabIndex = 1;
            this.tbUsername.text = "";
            this.tbUsername.OnTextChange += new System.EventHandler(this.tbUsername_OnTextChange);
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.Silver;
            this.tbPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbPassword.BackgroundImage")));
            this.tbPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbPassword.ForeColor = System.Drawing.Color.SeaShell;
            this.tbPassword.Icon = ((System.Drawing.Image)(resources.GetObject("tbPassword.Icon")));
            this.tbPassword.Location = new System.Drawing.Point(1032, 194);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(333, 52);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.text = "";
            // 
            // btnLogin
            // 
            this.btnLogin.Activecolor = System.Drawing.Color.OrangeRed;
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogin.BorderRadius = 0;
            this.btnLogin.ButtonText = "bunifuFlatButton1";
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.DisabledColor = System.Drawing.Color.Gray;
            this.btnLogin.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLogin.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnLogin.Iconimage")));
            this.btnLogin.Iconimage_right = null;
            this.btnLogin.Iconimage_right_Selected = null;
            this.btnLogin.Iconimage_Selected = null;
            this.btnLogin.IconMarginLeft = 0;
            this.btnLogin.IconMarginRight = 0;
            this.btnLogin.IconRightVisible = true;
            this.btnLogin.IconRightZoom = 0D;
            this.btnLogin.IconVisible = true;
            this.btnLogin.IconZoom = 90D;
            this.btnLogin.IsTab = false;
            this.btnLogin.Location = new System.Drawing.Point(1720, 469);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnLogin.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnLogin.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLogin.selected = false;
            this.btnLogin.Size = new System.Drawing.Size(556, 96);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "bunifuFlatButton1";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Textcolor = System.Drawing.Color.White;
            this.btnLogin.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnLog
            // 
            this.btnLog.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLog.BorderRadius = 0;
            this.btnLog.ButtonText = "Login";
            this.btnLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLog.DisabledColor = System.Drawing.Color.Gray;
            this.btnLog.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLog.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnLog.Iconimage")));
            this.btnLog.Iconimage_right = null;
            this.btnLog.Iconimage_right_Selected = null;
            this.btnLog.Iconimage_Selected = null;
            this.btnLog.IconMarginLeft = 0;
            this.btnLog.IconMarginRight = 0;
            this.btnLog.IconRightVisible = true;
            this.btnLog.IconRightZoom = 0D;
            this.btnLog.IconVisible = true;
            this.btnLog.IconZoom = 50D;
            this.btnLog.IsTab = false;
            this.btnLog.Location = new System.Drawing.Point(1032, 288);
            this.btnLog.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnLog.Name = "btnLog";
            this.btnLog.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnLog.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnLog.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLog.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnLog.selected = false;
            this.btnLog.Size = new System.Drawing.Size(333, 52);
            this.btnLog.TabIndex = 4;
            this.btnLog.Text = "Login";
            this.btnLog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLog.Textcolor = System.Drawing.Color.White;
            this.btnLog.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // frmMainpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UnifyPaper.Properties.Resources.UP1;
            this.ClientSize = new System.Drawing.Size(1420, 452);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMainpage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuTextbox tbUsername;
        private Bunifu.Framework.UI.BunifuTextbox tbPassword;
        private Bunifu.Framework.UI.BunifuFlatButton btnLogin;
        private Bunifu.Framework.UI.BunifuFlatButton btnLog;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}

