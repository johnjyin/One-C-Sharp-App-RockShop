namespace Rockshop
{
    partial class frmMedia
    {
        /// <summary>
        /// Required designer variable.
        /// author: john yin
        /// version: V0.1
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

        private const uint WM_UPDATEUISTATE = 0x0128;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuInsert = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quickMediaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openTestDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRoyaltyOwners = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtFileType = new System.Windows.Forms.TextBox();
            this.txtDateAdded = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtUnitRoyalty = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRoyaltyAddress = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRoyaltyOwner = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRoyaltyNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUrlMedia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUrlSampler = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProductType = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProductNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grdMedia = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMedia)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.mnuInsert,
            this.saveToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.testToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(718, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.refreshToolStripMenuItem.Text = "&Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // mnuInsert
            // 
            this.mnuInsert.Name = "mnuInsert";
            this.mnuInsert.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.mnuInsert.Size = new System.Drawing.Size(48, 20);
            this.mnuInsert.Text = "&Insert";
            this.mnuInsert.Click += new System.EventHandler(this.mnuInsert_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.saveToolStripMenuItem.Text = "S&ave";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allSearchToolStripMenuItem,
            this.advSearchToolStripMenuItem});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // allSearchToolStripMenuItem
            // 
            this.allSearchToolStripMenuItem.Name = "allSearchToolStripMenuItem";
            this.allSearchToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.allSearchToolStripMenuItem.Text = "All Search";
            this.allSearchToolStripMenuItem.Click += new System.EventHandler(this.allSearchToolStripMenuItem_Click);
            // 
            // advSearchToolStripMenuItem
            // 
            this.advSearchToolStripMenuItem.Name = "advSearchToolStripMenuItem";
            this.advSearchToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.advSearchToolStripMenuItem.Text = "Adv Search";
            this.advSearchToolStripMenuItem.Click += new System.EventHandler(this.advSearchToolStripMenuItem_Click);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quickMediaToolStripMenuItem,
            this.openTestDataToolStripMenuItem});
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.testToolStripMenuItem.Text = "Test";
            // 
            // quickMediaToolStripMenuItem
            // 
            this.quickMediaToolStripMenuItem.Name = "quickMediaToolStripMenuItem";
            this.quickMediaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.quickMediaToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.quickMediaToolStripMenuItem.Text = "Quick Media";
            this.quickMediaToolStripMenuItem.Click += new System.EventHandler(this.quickMediaToolStripMenuItem_Click);
            // 
            // openTestDataToolStripMenuItem
            // 
            this.openTestDataToolStripMenuItem.Name = "openTestDataToolStripMenuItem";
            this.openTestDataToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.openTestDataToolStripMenuItem.Text = "Excel Data - Medias";
            this.openTestDataToolStripMenuItem.Click += new System.EventHandler(this.openTestDataToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRoyaltyOwners);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtFileType);
            this.panel1.Controls.Add(this.txtDateAdded);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtUnitRoyalty);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtRoyaltyAddress);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtRoyaltyOwner);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtRoyaltyNo);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtUnitPrice);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtUrlMedia);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtUrlSampler);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtProductType);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtProductName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtProductNo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 337);
            this.panel1.TabIndex = 1;
            // 
            // btnRoyaltyOwners
            // 
            this.btnRoyaltyOwners.Location = new System.Drawing.Point(452, 194);
            this.btnRoyaltyOwners.Name = "btnRoyaltyOwners";
            this.btnRoyaltyOwners.Size = new System.Drawing.Size(32, 23);
            this.btnRoyaltyOwners.TabIndex = 44;
            this.btnRoyaltyOwners.Text = "...";
            this.btnRoyaltyOwners.UseVisualStyleBackColor = true;
            this.btnRoyaltyOwners.Click += new System.EventHandler(this.btnRoyaltyOwners_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(518, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "FileType:";
            // 
            // txtFileType
            // 
            this.txtFileType.Location = new System.Drawing.Point(578, 55);
            this.txtFileType.Name = "txtFileType";
            this.txtFileType.Size = new System.Drawing.Size(100, 20);
            this.txtFileType.TabIndex = 7;
            // 
            // txtDateAdded
            // 
            this.txtDateAdded.Location = new System.Drawing.Point(333, 300);
            this.txtDateAdded.Name = "txtDateAdded";
            this.txtDateAdded.Size = new System.Drawing.Size(112, 20);
            this.txtDateAdded.TabIndex = 43;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(243, 304);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 42;
            this.label11.Text = "Data Added:";
            // 
            // txtUnitRoyalty
            // 
            this.txtUnitRoyalty.Location = new System.Drawing.Point(333, 265);
            this.txtUnitRoyalty.Name = "txtUnitRoyalty";
            this.txtUnitRoyalty.Size = new System.Drawing.Size(112, 20);
            this.txtUnitRoyalty.TabIndex = 41;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(243, 269);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 40;
            this.label10.Text = "Unit Royalty:";
            // 
            // txtRoyaltyAddress
            // 
            this.txtRoyaltyAddress.Location = new System.Drawing.Point(578, 230);
            this.txtRoyaltyAddress.Name = "txtRoyaltyAddress";
            this.txtRoyaltyAddress.ReadOnly = true;
            this.txtRoyaltyAddress.Size = new System.Drawing.Size(100, 20);
            this.txtRoyaltyAddress.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(520, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Address:";
            // 
            // txtRoyaltyOwner
            // 
            this.txtRoyaltyOwner.Location = new System.Drawing.Point(578, 195);
            this.txtRoyaltyOwner.Name = "txtRoyaltyOwner";
            this.txtRoyaltyOwner.ReadOnly = true;
            this.txtRoyaltyOwner.Size = new System.Drawing.Size(100, 20);
            this.txtRoyaltyOwner.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(489, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Royalty Owner:";
            // 
            // txtRoyaltyNo
            // 
            this.txtRoyaltyNo.Location = new System.Drawing.Point(333, 195);
            this.txtRoyaltyNo.Name = "txtRoyaltyNo";
            this.txtRoyaltyNo.ReadOnly = true;
            this.txtRoyaltyNo.Size = new System.Drawing.Size(112, 20);
            this.txtRoyaltyNo.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(243, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Royalty No:";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(333, 160);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(112, 20);
            this.txtUnitPrice.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(243, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Unit Price:";
            // 
            // txtUrlMedia
            // 
            this.txtUrlMedia.Location = new System.Drawing.Point(333, 125);
            this.txtUrlMedia.Name = "txtUrlMedia";
            this.txtUrlMedia.Size = new System.Drawing.Size(345, 20);
            this.txtUrlMedia.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(243, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "URL Media:";
            // 
            // txtUrlSampler
            // 
            this.txtUrlSampler.Location = new System.Drawing.Point(333, 90);
            this.txtUrlSampler.Name = "txtUrlSampler";
            this.txtUrlSampler.Size = new System.Drawing.Size(345, 20);
            this.txtUrlSampler.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(243, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "URL (Sampler):";
            // 
            // txtProductType
            // 
            this.txtProductType.Location = new System.Drawing.Point(333, 55);
            this.txtProductType.Name = "txtProductType";
            this.txtProductType.Size = new System.Drawing.Size(112, 20);
            this.txtProductType.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Location = new System.Drawing.Point(243, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Product Type:";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(333, 20);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(345, 20);
            this.txtProductName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product Name:";
            // 
            // txtProductNo
            // 
            this.txtProductNo.Location = new System.Drawing.Point(89, 20);
            this.txtProductNo.Name = "txtProductNo";
            this.txtProductNo.ReadOnly = true;
            this.txtProductNo.Size = new System.Drawing.Size(112, 20);
            this.txtProductNo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product No:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.grdMedia);
            this.panel2.Location = new System.Drawing.Point(0, 377);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(717, 142);
            this.panel2.TabIndex = 2;
            // 
            // grdMedia
            // 
            this.grdMedia.AllowUserToAddRows = false;
            this.grdMedia.AllowUserToDeleteRows = false;
            this.grdMedia.AllowUserToResizeRows = false;
            this.grdMedia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdMedia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMedia.Location = new System.Drawing.Point(6, 2);
            this.grdMedia.MultiSelect = false;
            this.grdMedia.Name = "grdMedia";
            this.grdMedia.ReadOnly = true;
            this.grdMedia.Size = new System.Drawing.Size(708, 136);
            this.grdMedia.TabIndex = 0;
            this.grdMedia.SelectionChanged += new System.EventHandler(this.grdMedia_SelectionChanged);
            // 
            // frmMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(718, 515);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMedia";
            this.Text = "Rock Shop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdMedia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtRoyaltyOwner;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRoyaltyNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUrlMedia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUrlSampler;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProductType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProductNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView grdMedia;
        private System.Windows.Forms.TextBox txtDateAdded;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtUnitRoyalty;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtRoyaltyAddress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripMenuItem mnuInsert;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtFileType;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quickMediaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openTestDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem advSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allSearchToolStripMenuItem;
        private System.Windows.Forms.Button btnRoyaltyOwners;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;

    }
}