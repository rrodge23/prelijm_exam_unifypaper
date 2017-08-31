namespace UnifyPaper.form.pages
{
    partial class frmDelete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDelete));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDeleteSelectedRow = new System.Windows.Forms.Button();
            this.btnDeleteTransaction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCancel.Location = new System.Drawing.Point(288, 289);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 40);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnDeleteSelectedRow
            // 
            this.btnDeleteSelectedRow.BackColor = System.Drawing.Color.Red;
            this.btnDeleteSelectedRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSelectedRow.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteSelectedRow.Location = new System.Drawing.Point(203, 157);
            this.btnDeleteSelectedRow.Name = "btnDeleteSelectedRow";
            this.btnDeleteSelectedRow.Size = new System.Drawing.Size(125, 82);
            this.btnDeleteSelectedRow.TabIndex = 9;
            this.btnDeleteSelectedRow.Text = "Delete Selected Row";
            this.btnDeleteSelectedRow.UseVisualStyleBackColor = false;
            // 
            // btnDeleteTransaction
            // 
            this.btnDeleteTransaction.BackColor = System.Drawing.Color.Red;
            this.btnDeleteTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTransaction.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteTransaction.Location = new System.Drawing.Point(335, 157);
            this.btnDeleteTransaction.Name = "btnDeleteTransaction";
            this.btnDeleteTransaction.Size = new System.Drawing.Size(125, 82);
            this.btnDeleteTransaction.TabIndex = 12;
            this.btnDeleteTransaction.Text = "Delete Transaction";
            this.btnDeleteTransaction.UseVisualStyleBackColor = false;
            // 
            // frmDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UnifyPaper.Properties.Resources.UP1;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.btnDeleteTransaction);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDeleteSelectedRow);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDelete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clear Current Row or Transaction";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDeleteSelectedRow;
        private System.Windows.Forms.Button btnDeleteTransaction;
    }
}