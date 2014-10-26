namespace Rockshop
{
    partial class frmSelectRoyaltyOwners
    {
        /// <summary>
        /// Required designer variable.
        /// author: john yin
        /// version: version: V0.1
        /// create date: 5/5/2014
        /// last update data: 5/5/2014
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
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grdRoyaltyOwners = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRoyaltyOwners)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(98, 349);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(418, 349);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grdRoyaltyOwners);
            this.panel1.Location = new System.Drawing.Point(-1, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 335);
            this.panel1.TabIndex = 3;
            // 
            // grdRoyaltyOwners
            // 
            this.grdRoyaltyOwners.AllowUserToAddRows = false;
            this.grdRoyaltyOwners.AllowUserToDeleteRows = false;
            this.grdRoyaltyOwners.AllowUserToResizeRows = false;
            this.grdRoyaltyOwners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdRoyaltyOwners.Location = new System.Drawing.Point(3, 3);
            this.grdRoyaltyOwners.MultiSelect = false;
            this.grdRoyaltyOwners.Name = "grdRoyaltyOwners";
            this.grdRoyaltyOwners.ReadOnly = true;
            this.grdRoyaltyOwners.Size = new System.Drawing.Size(586, 329);
            this.grdRoyaltyOwners.TabIndex = 0;
            this.grdRoyaltyOwners.SelectionChanged += new System.EventHandler(this.grdRoyaltyOwners_SelectionChanged);
            // 
            // frmSelectRoyaltyOwners
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(587, 384);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.MaximumSize = new System.Drawing.Size(603, 422);
            this.Name = "frmSelectRoyaltyOwners";
            this.Text = "Select Royalty Owner";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdRoyaltyOwners)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView grdRoyaltyOwners;
    }
}