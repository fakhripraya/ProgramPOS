namespace ProgramOf
{
    partial class FrmMasterBarang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMasterBarang));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_IsiBaru = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKodeBarang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMerkBarang = new System.Windows.Forms.TextBox();
            this.txtNamaBarang = new System.Windows.Forms.TextBox();
            this.txtKodeDivisi = new System.Windows.Forms.TextBox();
            this.txtKodeGroup = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtKodeKategori = new System.Windows.Forms.TextBox();
            this.txtSatuan = new System.Windows.Forms.TextBox();
            this.txtHargaJual = new System.Windows.Forms.TextBox();
            this.txtHargaBotol = new System.Windows.Forms.TextBox();
            this.txtHargaAvgBlnIni = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtHargaAvgBlnLalu = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtQtyAwal = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtJumlahAwal = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNamaDivisi = new System.Windows.Forms.TextBox();
            this.txtNamaGroup = new System.Windows.Forms.TextBox();
            this.txtNamaKategori = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.chkPerubahanHrg = new System.Windows.Forms.CheckBox();
            this.chkHrgJualNol = new System.Windows.Forms.CheckBox();
            this.chkBrgKenaPajak = new System.Windows.Forms.CheckBox();
            this.chkBrgTdkKenaDiskon = new System.Windows.Forms.CheckBox();
            this.SearchKodeBarang = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(30, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "MASTER BARANG";
            // 
            // btn_IsiBaru
            // 
            this.btn_IsiBaru.BackColor = System.Drawing.Color.Transparent;
            this.btn_IsiBaru.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_IsiBaru.BackgroundImage")));
            this.btn_IsiBaru.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_IsiBaru.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_IsiBaru.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_IsiBaru.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_IsiBaru.ForeColor = System.Drawing.Color.Transparent;
            this.btn_IsiBaru.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_IsiBaru.Location = new System.Drawing.Point(311, 11);
            this.btn_IsiBaru.Name = "btn_IsiBaru";
            this.btn_IsiBaru.Size = new System.Drawing.Size(60, 35);
            this.btn_IsiBaru.TabIndex = 1;
            this.btn_IsiBaru.Text = "&Isi Baru";
            this.btn_IsiBaru.UseVisualStyleBackColor = false;
            this.btn_IsiBaru.Click += new System.EventHandler(this.btn_IsiBaru_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.Transparent;
            this.btnSimpan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSimpan.BackgroundImage")));
            this.btnSimpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.ForeColor = System.Drawing.Color.Transparent;
            this.btnSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSimpan.Location = new System.Drawing.Point(376, 11);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(60, 35);
            this.btnSimpan.TabIndex = 6;
            this.btnSimpan.Text = "&Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.BackgroundImage")));
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Transparent;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.Location = new System.Drawing.Point(441, 11);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(60, 35);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.Transparent;
            this.btnHapus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHapus.BackgroundImage")));
            this.btnHapus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapus.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapus.ForeColor = System.Drawing.Color.Transparent;
            this.btnHapus.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHapus.Location = new System.Drawing.Point(502, 11);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(60, 35);
            this.btnHapus.TabIndex = 8;
            this.btnHapus.Text = "&Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnKeluar
            // 
            this.btnKeluar.BackColor = System.Drawing.Color.Transparent;
            this.btnKeluar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKeluar.BackgroundImage")));
            this.btnKeluar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeluar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeluar.ForeColor = System.Drawing.Color.Transparent;
            this.btnKeluar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKeluar.Location = new System.Drawing.Point(563, 11);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(60, 35);
            this.btnKeluar.TabIndex = 9;
            this.btnKeluar.Text = "&Keluar";
            this.btnKeluar.UseVisualStyleBackColor = false;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "PLU";
            // 
            // txtKodeBarang
            // 
            this.txtKodeBarang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtKodeBarang.Location = new System.Drawing.Point(116, 62);
            this.txtKodeBarang.MaxLength = 10;
            this.txtKodeBarang.Name = "txtKodeBarang";
            this.txtKodeBarang.Size = new System.Drawing.Size(92, 20);
            this.txtKodeBarang.TabIndex = 11;
            this.txtKodeBarang.TextChanged += new System.EventHandler(this.txtKodeBarang_TextChanged);
            this.txtKodeBarang.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtKodeBarang_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Merk Barang";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nama Barang";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Kode Divisi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(46, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Kode Group";
            // 
            // txtMerkBarang
            // 
            this.txtMerkBarang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtMerkBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMerkBarang.Location = new System.Drawing.Point(116, 88);
            this.txtMerkBarang.Name = "txtMerkBarang";
            this.txtMerkBarang.Size = new System.Drawing.Size(237, 20);
            this.txtMerkBarang.TabIndex = 16;
            // 
            // txtNamaBarang
            // 
            this.txtNamaBarang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtNamaBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamaBarang.Location = new System.Drawing.Point(116, 115);
            this.txtNamaBarang.Name = "txtNamaBarang";
            this.txtNamaBarang.Size = new System.Drawing.Size(237, 20);
            this.txtNamaBarang.TabIndex = 17;
            // 
            // txtKodeDivisi
            // 
            this.txtKodeDivisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtKodeDivisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKodeDivisi.ForeColor = System.Drawing.Color.Black;
            this.txtKodeDivisi.Location = new System.Drawing.Point(116, 141);
            this.txtKodeDivisi.Name = "txtKodeDivisi";
            this.txtKodeDivisi.Size = new System.Drawing.Size(92, 20);
            this.txtKodeDivisi.TabIndex = 18;
            this.txtKodeDivisi.TextChanged += new System.EventHandler(this.txtKodeDivisi_TextChanged);
            this.txtKodeDivisi.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtKodeDivisi_KeyUp);
            // 
            // txtKodeGroup
            // 
            this.txtKodeGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtKodeGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKodeGroup.Location = new System.Drawing.Point(116, 167);
            this.txtKodeGroup.Name = "txtKodeGroup";
            this.txtKodeGroup.Size = new System.Drawing.Size(92, 20);
            this.txtKodeGroup.TabIndex = 19;
            this.txtKodeGroup.TextChanged += new System.EventHandler(this.txtKodeGroup_TextChanged);
            this.txtKodeGroup.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtKodeGroup_KeyUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "Kode Kategori";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(69, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "Satuan";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(52, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "Harga Jual";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(47, 274);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 15);
            this.label10.TabIndex = 23;
            this.label10.Text = "Harga Botol";
            // 
            // txtKodeKategori
            // 
            this.txtKodeKategori.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtKodeKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKodeKategori.Location = new System.Drawing.Point(116, 193);
            this.txtKodeKategori.Name = "txtKodeKategori";
            this.txtKodeKategori.Size = new System.Drawing.Size(92, 20);
            this.txtKodeKategori.TabIndex = 24;
            this.txtKodeKategori.TextChanged += new System.EventHandler(this.txtKodeKategori_TextChanged);
            this.txtKodeKategori.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtKodeKategori_KeyUp);
            // 
            // txtSatuan
            // 
            this.txtSatuan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtSatuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSatuan.Location = new System.Drawing.Point(116, 219);
            this.txtSatuan.Name = "txtSatuan";
            this.txtSatuan.Size = new System.Drawing.Size(237, 20);
            this.txtSatuan.TabIndex = 25;
            // 
            // txtHargaJual
            // 
            this.txtHargaJual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtHargaJual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHargaJual.Location = new System.Drawing.Point(116, 245);
            this.txtHargaJual.Name = "txtHargaJual";
            this.txtHargaJual.Size = new System.Drawing.Size(237, 20);
            this.txtHargaJual.TabIndex = 26;
            // 
            // txtHargaBotol
            // 
            this.txtHargaBotol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtHargaBotol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHargaBotol.Location = new System.Drawing.Point(116, 271);
            this.txtHargaBotol.Name = "txtHargaBotol";
            this.txtHargaBotol.Size = new System.Drawing.Size(237, 20);
            this.txtHargaBotol.TabIndex = 27;
            // 
            // txtHargaAvgBlnIni
            // 
            this.txtHargaAvgBlnIni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtHargaAvgBlnIni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHargaAvgBlnIni.ForeColor = System.Drawing.Color.White;
            this.txtHargaAvgBlnIni.Location = new System.Drawing.Point(116, 297);
            this.txtHargaAvgBlnIni.Name = "txtHargaAvgBlnIni";
            this.txtHargaAvgBlnIni.Size = new System.Drawing.Size(237, 20);
            this.txtHargaAvgBlnIni.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(19, 300);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 15);
            this.label11.TabIndex = 28;
            this.label11.Text = "Hrg AVG bulan ini";
            // 
            // txtHargaAvgBlnLalu
            // 
            this.txtHargaAvgBlnLalu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtHargaAvgBlnLalu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHargaAvgBlnLalu.ForeColor = System.Drawing.Color.White;
            this.txtHargaAvgBlnLalu.Location = new System.Drawing.Point(116, 323);
            this.txtHargaAvgBlnLalu.Name = "txtHargaAvgBlnLalu";
            this.txtHargaAvgBlnLalu.Size = new System.Drawing.Size(237, 20);
            this.txtHargaAvgBlnLalu.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(13, 326);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 15);
            this.label12.TabIndex = 30;
            this.label12.Text = "Hrg AVG bulan lalu";
            // 
            // txtQtyAwal
            // 
            this.txtQtyAwal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtQtyAwal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtyAwal.Location = new System.Drawing.Point(116, 349);
            this.txtQtyAwal.Name = "txtQtyAwal";
            this.txtQtyAwal.Size = new System.Drawing.Size(237, 20);
            this.txtQtyAwal.TabIndex = 33;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(61, 352);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 15);
            this.label13.TabIndex = 32;
            this.label13.Text = "Qty Awal";
            // 
            // txtJumlahAwal
            // 
            this.txtJumlahAwal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtJumlahAwal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJumlahAwal.Location = new System.Drawing.Point(116, 375);
            this.txtJumlahAwal.Name = "txtJumlahAwal";
            this.txtJumlahAwal.Size = new System.Drawing.Size(237, 20);
            this.txtJumlahAwal.TabIndex = 35;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(21, 378);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 15);
            this.label14.TabIndex = 34;
            this.label14.Text = "Jumlah Awal (Rp)";
            // 
            // txtNamaDivisi
            // 
            this.txtNamaDivisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtNamaDivisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamaDivisi.ForeColor = System.Drawing.Color.Transparent;
            this.txtNamaDivisi.Location = new System.Drawing.Point(214, 141);
            this.txtNamaDivisi.Name = "txtNamaDivisi";
            this.txtNamaDivisi.Size = new System.Drawing.Size(139, 20);
            this.txtNamaDivisi.TabIndex = 36;
            // 
            // txtNamaGroup
            // 
            this.txtNamaGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtNamaGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamaGroup.ForeColor = System.Drawing.Color.White;
            this.txtNamaGroup.Location = new System.Drawing.Point(214, 167);
            this.txtNamaGroup.Name = "txtNamaGroup";
            this.txtNamaGroup.Size = new System.Drawing.Size(139, 20);
            this.txtNamaGroup.TabIndex = 37;
            // 
            // txtNamaKategori
            // 
            this.txtNamaKategori.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtNamaKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamaKategori.ForeColor = System.Drawing.Color.White;
            this.txtNamaKategori.Location = new System.Drawing.Point(214, 193);
            this.txtNamaKategori.Name = "txtNamaKategori";
            this.txtNamaKategori.Size = new System.Drawing.Size(139, 20);
            this.txtNamaKategori.TabIndex = 38;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label15.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(422, 170);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(170, 22);
            this.label15.TabIndex = 668;
            this.label15.Text = "KRITERIA BARANG";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkPerubahanHrg
            // 
            this.chkPerubahanHrg.AutoSize = true;
            this.chkPerubahanHrg.BackColor = System.Drawing.Color.Transparent;
            this.chkPerubahanHrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPerubahanHrg.ForeColor = System.Drawing.Color.Black;
            this.chkPerubahanHrg.Location = new System.Drawing.Point(425, 266);
            this.chkPerubahanHrg.Name = "chkPerubahanHrg";
            this.chkPerubahanHrg.Size = new System.Drawing.Size(125, 17);
            this.chkPerubahanHrg.TabIndex = 672;
            this.chkPerubahanHrg.Text = "Perubahan Harga";
            this.chkPerubahanHrg.UseVisualStyleBackColor = false;
            // 
            // chkHrgJualNol
            // 
            this.chkHrgJualNol.AutoSize = true;
            this.chkHrgJualNol.BackColor = System.Drawing.Color.Transparent;
            this.chkHrgJualNol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHrgJualNol.ForeColor = System.Drawing.Color.Black;
            this.chkHrgJualNol.Location = new System.Drawing.Point(425, 220);
            this.chkHrgJualNol.Name = "chkHrgJualNol";
            this.chkHrgJualNol.Size = new System.Drawing.Size(167, 17);
            this.chkHrgJualNol.TabIndex = 671;
            this.chkHrgJualNol.Text = "Harga Jual Boleh NOL(0)";
            this.chkHrgJualNol.UseVisualStyleBackColor = false;
            // 
            // chkBrgKenaPajak
            // 
            this.chkBrgKenaPajak.AutoSize = true;
            this.chkBrgKenaPajak.BackColor = System.Drawing.Color.Transparent;
            this.chkBrgKenaPajak.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBrgKenaPajak.ForeColor = System.Drawing.Color.Black;
            this.chkBrgKenaPajak.Location = new System.Drawing.Point(425, 243);
            this.chkBrgKenaPajak.Name = "chkBrgKenaPajak";
            this.chkBrgKenaPajak.Size = new System.Drawing.Size(135, 17);
            this.chkBrgKenaPajak.TabIndex = 670;
            this.chkBrgKenaPajak.Text = "Barang Kena Pajak";
            this.chkBrgKenaPajak.UseVisualStyleBackColor = false;
            // 
            // chkBrgTdkKenaDiskon
            // 
            this.chkBrgTdkKenaDiskon.AutoSize = true;
            this.chkBrgTdkKenaDiskon.BackColor = System.Drawing.Color.Transparent;
            this.chkBrgTdkKenaDiskon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBrgTdkKenaDiskon.ForeColor = System.Drawing.Color.Black;
            this.chkBrgTdkKenaDiskon.Location = new System.Drawing.Point(425, 199);
            this.chkBrgTdkKenaDiskon.Name = "chkBrgTdkKenaDiskon";
            this.chkBrgTdkKenaDiskon.Size = new System.Drawing.Size(156, 17);
            this.chkBrgTdkKenaDiskon.TabIndex = 669;
            this.chkBrgTdkKenaDiskon.Text = "Barang Tidak Discount";
            this.chkBrgTdkKenaDiskon.UseVisualStyleBackColor = false;
            // 
            // SearchKodeBarang
            // 
            this.SearchKodeBarang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.SearchKodeBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchKodeBarang.Font = new System.Drawing.Font("Agency FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchKodeBarang.Image = ((System.Drawing.Image)(resources.GetObject("SearchKodeBarang.Image")));
            this.SearchKodeBarang.Location = new System.Drawing.Point(214, 56);
            this.SearchKodeBarang.Name = "SearchKodeBarang";
            this.SearchKodeBarang.Size = new System.Drawing.Size(35, 30);
            this.SearchKodeBarang.TabIndex = 673;
            this.SearchKodeBarang.UseVisualStyleBackColor = false;
            this.SearchKodeBarang.Click += new System.EventHandler(this.SearchKodeBarang_Click);
            // 
            // FrmMasterBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(634, 412);
            this.ControlBox = false;
            this.Controls.Add(this.SearchKodeBarang);
            this.Controls.Add(this.chkPerubahanHrg);
            this.Controls.Add(this.chkHrgJualNol);
            this.Controls.Add(this.chkBrgKenaPajak);
            this.Controls.Add(this.chkBrgTdkKenaDiskon);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtNamaKategori);
            this.Controls.Add(this.txtNamaGroup);
            this.Controls.Add(this.txtNamaDivisi);
            this.Controls.Add(this.txtJumlahAwal);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtQtyAwal);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtHargaAvgBlnLalu);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtHargaAvgBlnIni);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtHargaBotol);
            this.Controls.Add(this.txtHargaJual);
            this.Controls.Add(this.txtSatuan);
            this.Controls.Add(this.txtKodeKategori);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtKodeGroup);
            this.Controls.Add(this.txtKodeDivisi);
            this.Controls.Add(this.txtNamaBarang);
            this.Controls.Add(this.txtMerkBarang);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKodeBarang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btn_IsiBaru);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMasterBarang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Master Barang";
            this.Load += new System.EventHandler(this.FrmMasterBarang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        internal System.Windows.Forms.Label label15;
        internal System.Windows.Forms.CheckBox chkPerubahanHrg;
        internal System.Windows.Forms.CheckBox chkHrgJualNol;
        internal System.Windows.Forms.CheckBox chkBrgKenaPajak;
        internal System.Windows.Forms.CheckBox chkBrgTdkKenaDiskon;
        private System.Windows.Forms.Button SearchKodeBarang;
        internal System.Windows.Forms.TextBox txtKodeBarang;
        internal System.Windows.Forms.TextBox txtMerkBarang;
        internal System.Windows.Forms.TextBox txtNamaBarang;
        internal System.Windows.Forms.TextBox txtKodeDivisi;
        internal System.Windows.Forms.TextBox txtKodeGroup;
        internal System.Windows.Forms.TextBox txtKodeKategori;
        internal System.Windows.Forms.TextBox txtSatuan;
        internal System.Windows.Forms.TextBox txtHargaJual;
        internal System.Windows.Forms.TextBox txtHargaBotol;
        internal System.Windows.Forms.TextBox txtHargaAvgBlnIni;
        internal System.Windows.Forms.TextBox txtHargaAvgBlnLalu;
        internal System.Windows.Forms.TextBox txtQtyAwal;
        internal System.Windows.Forms.TextBox txtJumlahAwal;
        internal System.Windows.Forms.TextBox txtNamaDivisi;
        internal System.Windows.Forms.TextBox txtNamaGroup;
        internal System.Windows.Forms.TextBox txtNamaKategori;
        internal System.Windows.Forms.Button btnSimpan;
        internal System.Windows.Forms.Button btnEdit;
        internal System.Windows.Forms.Button btnHapus;
        internal System.Windows.Forms.Button btnKeluar;
        internal System.Windows.Forms.Button btn_IsiBaru;
    }
}