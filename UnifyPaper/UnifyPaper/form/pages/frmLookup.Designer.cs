namespace UnifyPaper.form.pages
{
    partial class frmLookup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLookup));
            this.lbLookupDescription = new System.Windows.Forms.Label();
            this.lbEnterSearchCharacters = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnDepartment = new System.Windows.Forms.Button();
            this.btnProductCode = new System.Windows.Forms.Button();
            this.btnProductDescription = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbLookupDescription
            // 
            this.lbLookupDescription.AutoSize = true;
            this.lbLookupDescription.BackColor = System.Drawing.Color.Transparent;
            this.lbLookupDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLookupDescription.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbLookupDescription.Location = new System.Drawing.Point(203, 53);
            this.lbLookupDescription.Name = "lbLookupDescription";
            this.lbLookupDescription.Size = new System.Drawing.Size(273, 29);
            this.lbLookupDescription.TabIndex = 0;
            this.lbLookupDescription.Text = "Lookup by Description";
            // 
            // lbEnterSearchCharacters
            // 
            this.lbEnterSearchCharacters.AutoSize = true;
            this.lbEnterSearchCharacters.BackColor = System.Drawing.Color.Transparent;
            this.lbEnterSearchCharacters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEnterSearchCharacters.Location = new System.Drawing.Point(75, 112);
            this.lbEnterSearchCharacters.Name = "lbEnterSearchCharacters";
            this.lbEnterSearchCharacters.Size = new System.Drawing.Size(257, 25);
            this.lbEnterSearchCharacters.TabIndex = 1;
            this.lbEnterSearchCharacters.Text = "Enter Search Characters:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(382, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 22);
            this.textBox1.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCancel.Location = new System.Drawing.Point(364, 359);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 40);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOk.Location = new System.Drawing.Point(229, 359);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(87, 40);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            // 
            // btnDepartment
            // 
            this.btnDepartment.BackColor = System.Drawing.Color.Red;
            this.btnDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepartment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDepartment.Location = new System.Drawing.Point(413, 225);
            this.btnDepartment.Name = "btnDepartment";
            this.btnDepartment.Size = new System.Drawing.Size(125, 82);
            this.btnDepartment.TabIndex = 9;
            this.btnDepartment.Text = "Lookup by Department";
            this.btnDepartment.UseVisualStyleBackColor = false;
            // 
            // btnProductCode
            // 
            this.btnProductCode.BackColor = System.Drawing.Color.Red;
            this.btnProductCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductCode.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProductCode.Location = new System.Drawing.Point(277, 225);
            this.btnProductCode.Name = "btnProductCode";
            this.btnProductCode.Size = new System.Drawing.Size(121, 82);
            this.btnProductCode.TabIndex = 8;
            this.btnProductCode.Text = "Lookup by Product Code";
            this.btnProductCode.UseVisualStyleBackColor = false;
            // 
            // btnProductDescription
            // 
            this.btnProductDescription.BackColor = System.Drawing.Color.Red;
            this.btnProductDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductDescription.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProductDescription.Location = new System.Drawing.Point(135, 225);
            this.btnProductDescription.Name = "btnProductDescription";
            this.btnProductDescription.Size = new System.Drawing.Size(125, 82);
            this.btnProductDescription.TabIndex = 7;
            this.btnProductDescription.Text = "Lookup by Product Description";
            this.btnProductDescription.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Enter one or more character to match.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmLookup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UnifyPaper.Properties.Resources.UP1;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnDepartment);
            this.Controls.Add(this.btnProductCode);
            this.Controls.Add(this.btnProductDescription);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbEnterSearchCharacters);
            this.Controls.Add(this.lbLookupDescription);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLookup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Lookup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbLookupDescription;
        private System.Windows.Forms.Label lbEnterSearchCharacters;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnDepartment;
        private System.Windows.Forms.Button btnProductCode;
        private System.Windows.Forms.Button btnProductDescription;
        private System.Windows.Forms.Label label1;
    }
}