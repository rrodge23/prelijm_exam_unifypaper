namespace UnifyPaper.form.pages
{
    partial class frmCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomer));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCustomerCode = new System.Windows.Forms.Button();
            this.btnLastName = new System.Windows.Forms.Button();
            this.btnCompanyName = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter/Scan Customer Code:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(390, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(219, 22);
            this.textBox1.TabIndex = 1;
            // 
            // btnCustomerCode
            // 
            this.btnCustomerCode.BackColor = System.Drawing.Color.Red;
            this.btnCustomerCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerCode.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCustomerCode.Location = new System.Drawing.Point(130, 175);
            this.btnCustomerCode.Name = "btnCustomerCode";
            this.btnCustomerCode.Size = new System.Drawing.Size(125, 82);
            this.btnCustomerCode.TabIndex = 2;
            this.btnCustomerCode.Text = "Lookup by Customer Code";
            this.btnCustomerCode.UseVisualStyleBackColor = false;
            // 
            // btnLastName
            // 
            this.btnLastName.BackColor = System.Drawing.Color.Red;
            this.btnLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLastName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLastName.Location = new System.Drawing.Point(272, 175);
            this.btnLastName.Name = "btnLastName";
            this.btnLastName.Size = new System.Drawing.Size(121, 82);
            this.btnLastName.TabIndex = 3;
            this.btnLastName.Text = "Lookup by Last Name";
            this.btnLastName.UseVisualStyleBackColor = false;
            // 
            // btnCompanyName
            // 
            this.btnCompanyName.BackColor = System.Drawing.Color.Red;
            this.btnCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompanyName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCompanyName.Location = new System.Drawing.Point(408, 175);
            this.btnCompanyName.Name = "btnCompanyName";
            this.btnCompanyName.Size = new System.Drawing.Size(125, 82);
            this.btnCompanyName.TabIndex = 4;
            this.btnCompanyName.Text = "Lookup by Company Name";
            this.btnCompanyName.UseVisualStyleBackColor = false;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOk.Location = new System.Drawing.Point(224, 309);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(87, 40);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCancel.Location = new System.Drawing.Point(359, 309);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 40);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UnifyPaper.Properties.Resources.UP1;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCompanyName);
            this.Controls.Add(this.btnLastName);
            this.Controls.Add(this.btnCustomerCode);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select or Add Customer";
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCustomerCode;
        private System.Windows.Forms.Button btnLastName;
        private System.Windows.Forms.Button btnCompanyName;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}