namespace UnifyPaper.form.pages
{
    partial class frmReCall
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReCall));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnSalesReturnPastTransaction = new System.Windows.Forms.Button();
            this.btnReprintLastSalesReceipt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCancel.Location = new System.Drawing.Point(299, 300);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 40);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnRestore
            // 
            this.btnRestore.BackColor = System.Drawing.Color.Red;
            this.btnRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRestore.Location = new System.Drawing.Point(418, 144);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(125, 82);
            this.btnRestore.TabIndex = 9;
            this.btnRestore.Text = "Restore Open (Saved) Transaction";
            this.btnRestore.UseVisualStyleBackColor = false;
            // 
            // btnSalesReturnPastTransaction
            // 
            this.btnSalesReturnPastTransaction.BackColor = System.Drawing.Color.Red;
            this.btnSalesReturnPastTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesReturnPastTransaction.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalesReturnPastTransaction.Location = new System.Drawing.Point(282, 144);
            this.btnSalesReturnPastTransaction.Name = "btnSalesReturnPastTransaction";
            this.btnSalesReturnPastTransaction.Size = new System.Drawing.Size(121, 82);
            this.btnSalesReturnPastTransaction.TabIndex = 8;
            this.btnSalesReturnPastTransaction.Text = "Sales Return from a Past Transaction";
            this.btnSalesReturnPastTransaction.UseVisualStyleBackColor = false;
            // 
            // btnReprintLastSalesReceipt
            // 
            this.btnReprintLastSalesReceipt.BackColor = System.Drawing.Color.Red;
            this.btnReprintLastSalesReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReprintLastSalesReceipt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReprintLastSalesReceipt.Location = new System.Drawing.Point(140, 144);
            this.btnReprintLastSalesReceipt.Name = "btnReprintLastSalesReceipt";
            this.btnReprintLastSalesReceipt.Size = new System.Drawing.Size(125, 82);
            this.btnReprintLastSalesReceipt.TabIndex = 7;
            this.btnReprintLastSalesReceipt.Text = "Reprint the Last Sales Receipt";
            this.btnReprintLastSalesReceipt.UseVisualStyleBackColor = false;
            // 
            // frmReCall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UnifyPaper.Properties.Resources.UP1;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.btnSalesReturnPastTransaction);
            this.Controls.Add(this.btnReprintLastSalesReceipt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReCall";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recall";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnSalesReturnPastTransaction;
        private System.Windows.Forms.Button btnReprintLastSalesReceipt;
    }
}