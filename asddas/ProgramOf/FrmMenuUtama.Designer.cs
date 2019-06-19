namespace ProgramOf
{
    partial class FrmMenuUtama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuUtama));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterBarangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuMaintenanceMaster = new System.Windows.Forms.ToolStripMenuItem();
            this.improtMasterBarangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuMasterPaket = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masukPOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bentukDataOracleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keluarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LblUserName = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterToolStripMenuItem,
            this.transaksiToolStripMenuItem,
            this.keluarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterBarangToolStripMenuItem,
            this.MnuMasterPaket,
            this.exitToolStripMenuItem});
            this.masterToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.masterToolStripMenuItem.Text = "Master";
            // 
            // masterBarangToolStripMenuItem
            // 
            this.masterBarangToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuMaintenanceMaster,
            this.improtMasterBarangToolStripMenuItem});
            this.masterBarangToolStripMenuItem.Name = "masterBarangToolStripMenuItem";
            this.masterBarangToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.masterBarangToolStripMenuItem.Text = "Master Barang";
            // 
            // MnuMaintenanceMaster
            // 
            this.MnuMaintenanceMaster.Name = "MnuMaintenanceMaster";
            this.MnuMaintenanceMaster.Size = new System.Drawing.Size(197, 22);
            this.MnuMaintenanceMaster.Text = "Maintenance";
            this.MnuMaintenanceMaster.Click += new System.EventHandler(this.MnuMaintenanceMaster_Click);
            // 
            // improtMasterBarangToolStripMenuItem
            // 
            this.improtMasterBarangToolStripMenuItem.Name = "improtMasterBarangToolStripMenuItem";
            this.improtMasterBarangToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.improtMasterBarangToolStripMenuItem.Text = "Improt Master Barang";
            // 
            // MnuMasterPaket
            // 
            this.MnuMasterPaket.Name = "MnuMasterPaket";
            this.MnuMasterPaket.Size = new System.Drawing.Size(155, 22);
            this.MnuMasterPaket.Text = "Master Paket";
            this.MnuMasterPaket.Click += new System.EventHandler(this.MnuMasterPaket_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // transaksiToolStripMenuItem
            // 
            this.transaksiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masukPOSToolStripMenuItem,
            this.bentukDataOracleToolStripMenuItem});
            this.transaksiToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transaksiToolStripMenuItem.Name = "transaksiToolStripMenuItem";
            this.transaksiToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.transaksiToolStripMenuItem.Text = "Transaksi";
            // 
            // masukPOSToolStripMenuItem
            // 
            this.masukPOSToolStripMenuItem.Name = "masukPOSToolStripMenuItem";
            this.masukPOSToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.masukPOSToolStripMenuItem.Text = "Masuk POS";
            this.masukPOSToolStripMenuItem.Click += new System.EventHandler(this.masukPOSToolStripMenuItem_Click);
            // 
            // bentukDataOracleToolStripMenuItem
            // 
            this.bentukDataOracleToolStripMenuItem.Name = "bentukDataOracleToolStripMenuItem";
            this.bentukDataOracleToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.bentukDataOracleToolStripMenuItem.Text = "Bentuk Data Oracle";
            // 
            // keluarToolStripMenuItem
            // 
            this.keluarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keluarToolStripMenuItem.Name = "keluarToolStripMenuItem";
            this.keluarToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.keluarToolStripMenuItem.Text = "Keluar";
            this.keluarToolStripMenuItem.Click += new System.EventHandler(this.keluarToolStripMenuItem_Click);
            // 
            // LblUserName
            // 
            this.LblUserName.AutoSize = true;
            this.LblUserName.BackColor = System.Drawing.Color.Transparent;
            this.LblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUserName.ForeColor = System.Drawing.Color.Black;
            this.LblUserName.Location = new System.Drawing.Point(685, 40);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(117, 20);
            this.LblUserName.TabIndex = 1;
            this.LblUserName.Text = "LblUserName";
            // 
            // FrmMenuUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 542);
            this.Controls.Add(this.LblUserName);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenuUtama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Utama";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMenuUtama_FormClosed);
            this.Load += new System.EventHandler(this.FrmMenuUtama_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem masterBarangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuMaintenanceMaster;
        private System.Windows.Forms.ToolStripMenuItem improtMasterBarangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuMasterPaket;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem transaksiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masukPOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bentukDataOracleToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem;
        private System.Windows.Forms.Label LblUserName;
        private System.Windows.Forms.ToolStripMenuItem keluarToolStripMenuItem;
    }
}