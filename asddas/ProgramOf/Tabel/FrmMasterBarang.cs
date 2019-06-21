using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProgramOf.DataAccess;
using MySql.Data.MySqlClient;

namespace ProgramOf
{
    public partial class FrmMasterBarang : Form, InSearch
    {
        private FrmMenuUtama f_mu;
        ModFunction md = new ModFunction();

        public FrmMasterBarang(FrmMenuUtama fmu)
        {
            f_mu = fmu;
            InitializeComponent();
        }
        
        //SetGet
        public string myQuery { get;  set; }
        public string value { get;  set; }
        public bool searchKodeBarang_clicked { get; set; }
        public bool searchKodeDivisi_clicked { get; set; }
        public bool searchKodeKategori_clicked { get; set; }
        public bool searchKodeGroup_clicked { get; set; }
        public bool searchKodePaket_clicked { get; set; }

        //set textbox boolean
        public void setText(bool kodeBarang, bool merkBarang, bool namaBarang, bool kodeDivisi,bool kodeGroup , bool kodeKategori, bool satuan, 
                            bool hargaJual, bool hargaBotol, bool hargaAvgBlnIni, bool hargaAvgBlnLalu, bool qty, bool jumlahAwal,
                            bool cekBrgTdkKenaDiskon, bool cekHrgJualNol, bool cekBrgKenaPajak, bool cekPerubahanHrg)
        {
            this.txtKodeBarang.Enabled = kodeBarang;
            this.txtMerkBarang.Enabled = merkBarang;
            this.txtNamaBarang.Enabled = namaBarang;
            this.txtKodeDivisi.Enabled = kodeDivisi;
            this.txtKodeGroup.Enabled = kodeGroup;
            this.txtKodeKategori.Enabled = kodeKategori;
            this.txtSatuan.Enabled = satuan;
            this.txtHargaJual.Enabled = hargaJual;
            this.txtHargaBotol.Enabled = hargaBotol;
            this.txtHargaAvgBlnIni.Enabled = hargaAvgBlnIni;
            this.txtHargaAvgBlnLalu.Enabled = hargaAvgBlnLalu;
            this.txtQtyAwal.Enabled = qty;
            this.txtJumlahAwal.Enabled = jumlahAwal;
            this.chkBrgTdkKenaDiskon.Enabled = cekBrgTdkKenaDiskon;
            this.chkHrgJualNol.Enabled = cekHrgJualNol;
            this.chkBrgKenaPajak.Enabled = cekBrgKenaPajak;
            this.chkPerubahanHrg.Enabled = cekPerubahanHrg;
        }

        //form load
        private void FrmMasterBarang_Load(object sender, EventArgs e)
        {
            btnHapus.Enabled = false;
            btnEdit.Enabled = false;
        }

        //klik isi baru
        private void btn_IsiBaru_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                if (c is CheckBox)
                {
                    ((CheckBox)c).Checked = false;
                }
                else if (c is TextBox)
                {
                    ((TextBox)c).Text = "";
                }
            }

            btnSimpan.Enabled = true;
            btnEdit.Enabled = false;
            btnHapus.Enabled = false;

            setText(true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true);
        }

        //klik edit
        public bool edit_clicked = false;
        private void btnEdit_Click(object sender, EventArgs e)
        {
            
            DialogResult dialogResult = MessageBox.Show("Apakah yakin ingin melakukan Koreksi terhadap data ini ?", "Peringatan", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                edit_clicked = true;
                btn_IsiBaru.Enabled = false;
                btnSimpan.Enabled = true;
                btnEdit.Enabled = false;
                btnHapus.Enabled = true;

                txtNamaDivisi.Enabled = false;
                txtNamaGroup.Enabled = false;
                txtNamaKategori.Enabled = false;

                setText(false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true);

            }
        }

        //klik simpan
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (this.txtKodeBarang.Text.Length < 1)
            {
                MessageBox.Show("Kode Barang Belum terisi ! ");
                this.txtKodeBarang.Focus();
            }

            else if (this.txtMerkBarang.Text.Length < 1)
            {
                MessageBox.Show("Merk Barang Belum terisi ! ");
                this.txtMerkBarang.Focus();
            }

            else if(this.txtNamaBarang.Text.Length < 1)
            {
                MessageBox.Show("Nama Barang Belum terisi ! ");
                this.txtNamaBarang.Focus();
            }

            else if (this.txtKodeDivisi.Text.Length < 1)
            {
                MessageBox.Show("Kode Divisi Belum terisi ! ");
                this.txtKodeDivisi.Focus();
            }

            else if (this.txtKodeGroup.Text.Length < 1)
            {
                MessageBox.Show("Kode Group Belum terisi ! ");
                this.txtKodeGroup.Focus();
            }

            else if (this.txtKodeKategori.Text.Length < 1)
            {
                MessageBox.Show("Kode Kategori Belum terisi ! ");
                this.txtKodeKategori.Focus();
            }

            else if (this.txtKodeDivisi.Text != null)
            {
                string cekKodeDivisi = md.vlookup("KodeDivisi", "SuDivisi", "KodeDivisi='" + this.txtKodeDivisi.Text + "'"); ;
                if (cekKodeDivisi == null)
                {
                    MessageBox.Show("Kode Divisi Tersebut Tidak Dapat Ditemukan");
                    this.txtKodeDivisi.Text = null;
                    this.txtKodeGroup.Text = null;
                    this.txtKodeKategori.Text = null;
                    txtKodeDivisi.Focus();
                }
                else if (this.txtKodeGroup.Text != null)
                {
                    string cekKodeGroup = md.vlookup("KodeDivisi", "SuGroup", "KodeGroup='" + this.txtKodeGroup.Text + "' ");
                    if (cekKodeGroup == null)
                    {
                        MessageBox.Show("Kode Group Tersebut Tidak ada dalam Tabel Divisi diatas");
                        this.txtKodeGroup.Text = null;
                        this.txtKodeKategori.Text = null;
                        txtKodeGroup.Focus();
                    }
                    else if (this.txtKodeKategori != null )
                    {
                        string cekKodeKateori = md.vlookup("KodeDivisi", "SuKategori", "KodeKategori='" + this.txtKodeKategori.Text + "'");
                        if (cekKodeKateori == null)
                        {
                            MessageBox.Show("Kode Kategori Tersebut Tidak ada dalam Tabel Divisi diatas");
                            this.txtKodeKategori.Text = null;
                        }
                    }
                }
            }

            MySqlConnection conn = DBUtils.GetDbConnection();
            conn.Open();

            string query;

            MySqlCommand command = conn.CreateCommand();
            MySqlTransaction trans = conn.BeginTransaction(IsolationLevel.ReadCommitted);

            try
            {
                if (edit_clicked == true)
                {
                    query =  " Update InBarangMst Set KodeBarang= '" + this.txtKodeBarang.Text + "', ";
                    query += " MerkBarang= '" + this.txtMerkBarang.Text + "', ";
                    query += " NamaBarang= '" + this.txtNamaBarang.Text + "', ";
                    query += " KodeDivisi= '" + this.txtKodeDivisi.Text + "', ";
                    query += " KodeGroup= '" + this.txtKodeGroup.Text + "', ";
                    query += " KodeKategori= '" + this.txtKodeKategori.Text + "', ";
                    query += " Satuan= '" + this.txtSatuan.Text + "', ";
                    query += " HargaJual= '" + System.Convert.ToDouble(this.txtHargaJual.Text) + "', ";
                    query += " HargaBotol= '" + System.Convert.ToDouble(this.txtHargaBotol.Text) + "', ";
                    query += " QtyAwal= '" + System.Convert.ToDouble(this.txtQtyAwal.Text) + "', ";
                    query += " JumlahAwal= '" + System.Convert.ToDouble(this.txtJumlahAwal.Text) + "', ";
                    query += " FlagTidakDiskon= '" + md.CB(this.chkBrgTdkKenaDiskon.Checked) + "', ";
                    query += " FlagHargaBolehNol= '" + md.CB(this.chkHrgJualNol.Checked) + "', ";
                    query += " FlagKenaPajak= '" + md.CB(this.chkBrgKenaPajak.Checked) + "', ";
                    query += " FlagPerubahanHarga= '" + md.CB(this.chkPerubahanHrg.Checked) + "', ";
                    query += " NamaUser='" + f_mu.log.ToString() + "'";
                    query += " Where KodeBarang= '" + this.txtKodeBarang.Text + "'";

                    command.CommandText = query;
                    command.ExecuteNonQuery();

                }

                else
                {
                    query =  " Insert into InBarangMst(KodeBarang,MerkBarang,NamaBarang,KodeDivisi,KodeGroup,KodeKategori,Satuan,";
                    query += " HargaJual,HargaBotol,QtyAwal,JumlahAwal,FlagTidakDiskon,FlagHargaBolehNol,FlagKenaPajak,";
                    query += " FlagPerubahanHarga,NamaUser)";
                    query += " values('" + this.txtKodeBarang.Text + "',";
                    query += " '" + this.txtMerkBarang.Text + "',";
                    query += " '" + this.txtNamaBarang.Text + "',";
                    query += " '" + this.txtKodeDivisi.Text + "',";
                    query += " '" + this.txtKodeGroup.Text + "',";
                    query += " '" + this.txtKodeKategori.Text + "',";
                    query += " '" + this.txtSatuan.Text + "',";
                    query += " '" + System.Convert.ToDouble(this.txtHargaJual.Text) + "',";
                    query += " '" + System.Convert.ToDouble(this.txtHargaBotol.Text) + "',";
                    query += " '" + System.Convert.ToDouble(this.txtQtyAwal.Text) + "',";
                    query += " '" + System.Convert.ToDouble(this.txtJumlahAwal.Text) + "',";
                    query += " '" + md.CB(this.chkBrgTdkKenaDiskon.Checked) + "',";
                    query += " '" + md.CB(this.chkHrgJualNol.Checked) + "',";
                    query += " '" + md.CB(this.chkBrgKenaPajak.Checked) + "',";
                    query += " '" + md.CB(this.chkPerubahanHrg.Checked) + "',";
                    query += " '" + f_mu.log.ToString() + "')";

                    command.CommandText = query;
                    command.ExecuteNonQuery();

                }
                trans.Commit();
                btn_IsiBaru_Click(sender, e);
                btn_IsiBaru.Enabled = true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                trans.Rollback();
            }
        }

        //klik Hapus
        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (txtKodeBarang.Text.Length < 1)
            {
                MessageBox.Show("Kode Barang Belum terisi ! ");
                txtKodeBarang.Focus();
            }
            else if (edit_clicked == true)
            {
                DialogResult dialogResult = MessageBox.Show("Apakah yakin ingin menghapus data ini ?", "Peringatan", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MySqlConnection conn = DBUtils.GetDbConnection();
                    conn.Open();
                    string query;
                    MySqlCommand command = conn.CreateCommand();
                    MySqlTransaction trans = conn.BeginTransaction(IsolationLevel.ReadCommitted);

                    try
                    {
                        query = "Delete From InBarangMst Where KodeBarang= '" + this.txtKodeBarang.Text + "'";

                        command.CommandText = query;
                        command.ExecuteNonQuery();

                        trans.Commit();
                        btn_IsiBaru_Click(sender, e);
                        btn_IsiBaru.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        trans.Rollback();
                    }

                }
            }
        }

        //Keluar Click
        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Search Icon
        private void SearchKodeBarang_Click(object sender, EventArgs e)
        {
            searchKodeBarang_clicked = true;
            searchKodeDivisi_clicked = false;
            searchKodeGroup_clicked = false;
            searchKodeKategori_clicked = false;

            myQuery = "select KodeBarang,MerkBarang,NamaBarang from InBarangMst";

            var search = new FrmCariData();
            search.ShowDialog(this);
            this.txtKodeBarang.Text = value;
            value = "";
        }

        //F1 KeyUp KodeBarang
        private void txtKodeBarang_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                searchKodeBarang_clicked = true;
                searchKodeDivisi_clicked = false;
                searchKodeGroup_clicked = false;
                searchKodeKategori_clicked = false;

                myQuery = "select KodeBarang,MerkBarang,NamaBarang from InBarangMst";

                var search = new FrmCariData();
                search.ShowDialog(this);
                this.txtKodeBarang.Text = value;
                value = "";
            }
        }

        //KodeBarang Change
        private void txtKodeBarang_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = DBUtils.GetDbConnection();
            conn.Open();

            string query = ("Select * from InBarangMst Where Kodebarang = @KodeBarangValue ");

            MySqlCommand command = new MySqlCommand();
            command.CommandText = query;
            command.Parameters.AddWithValue("@KodeBarangValue", txtKodeBarang.Text);
            command.Connection = conn;
            MySqlDataReader reader = command.ExecuteReader();
           

            if (reader.HasRows)
            {
                reader.Read();
                txtKodeBarang.Text = reader["KodeBarang"].ToString();
                txtMerkBarang.Text = reader["MerkBarang"].ToString();
                txtNamaBarang.Text = reader["NamaBarang"].ToString();
                txtKodeDivisi.Text = reader["KodeDivisi"].ToString();
                txtKodeGroup.Text = reader["KodeGroup"].ToString();
                txtKodeKategori.Text = reader["KodeKategori"].ToString();
                txtSatuan.Text = reader["satuan"].ToString();
                txtHargaJual.Text = reader["HargaJual"].ToString();
                txtHargaBotol.Text = reader["HargaBotol"].ToString();
                txtHargaAvgBlnIni.Text = reader["HargaPokokBlnIni"].ToString();
                txtHargaAvgBlnLalu.Text = reader["HargaPokokBlnLalu"].ToString();
                txtQtyAwal.Text = reader["QtyAwal"].ToString();
                txtJumlahAwal.Text = reader["JumlahAwal"].ToString();

                chkBrgTdkKenaDiskon.Checked = reader.GetBoolean("FlagTidakDiskon");
                chkHrgJualNol.Checked = reader.GetBoolean("FlagHargaBolehNol");
                chkBrgKenaPajak.Checked = reader.GetBoolean("FlagKenaPajak");
                chkPerubahanHrg.Checked = reader.GetBoolean("FlagPerubahanHarga");

                txtNamaDivisi.Text = md.vlookup("NamaDivisi", "SuDivisi", "KodeDivisi='" + this.txtKodeDivisi.Text + "'");
                txtNamaGroup.Text = md.vlookup("NamaGroup", "SuGroup", "KodeGroup='" + this.txtKodeGroup.Text + "'");
                txtNamaKategori.Text = md.vlookup("NamaKategori", "SuKategori", "KodeKategori='" + this.txtKodeKategori.Text + "'");

                conn.Close();

                btnSimpan.Enabled = false;
                btnEdit.Enabled = true;
                btnHapus.Enabled = false;

                //setText(true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false);
            }
            else
            {
                foreach (Control c in this.Controls)
                {
                    if (c is TextBox && c != null)
                    {
                        if (c.Name != "txtKodeBarang")
                        {
                            c.Text = "";
                        }
                    }

                    else if (c is CheckBox)
                    {
                        ((CheckBox)c).Checked = false;
                    }
                }

                btnSimpan.Enabled = true;
                btnEdit.Enabled = false;
                btnHapus.Enabled = false;

                setText(true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true);

            }
            
        }
    
        //F1 KeyUp KodeDivisi
        private void txtKodeDivisi_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                this.searchKodeBarang_clicked = false;
                this.searchKodeDivisi_clicked = true;
                this.searchKodeGroup_clicked = false;
                this.searchKodeKategori_clicked = false;

                this.myQuery = "select KodeDivisi,NamaDivisi from SuDivisi";

                var search = new FrmCariData();
                search.ShowDialog(this);

                txtKodeGroup.Text = null;
                this.txtKodeDivisi.Text = value;
                value = "";

            }
        }

        //KodeDivisi Change
        private void txtKodeDivisi_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = DBUtils.GetDbConnection();
            conn.Open();

            string query = ("Select * from SuDivisi Where KodeDivisi = @KodeDivisiValue");

            //MySqlCommand command = new MySqlCommand(query, conn);
            //MySqlDataReader reader = command.ExecuteReader();

            MySqlCommand command = new MySqlCommand();
            command.CommandText = query;
            command.Parameters.AddWithValue("@KodeDivisiValue",txtKodeDivisi.Text);
            command.Connection = conn;
            MySqlDataReader reader = command.ExecuteReader();

            try
            {
                if (reader.HasRows)
                {
                    reader.Read();
                    this.txtNamaDivisi.Text = md.vlookup("NamaDivisi", "SuDivisi", "KodeDivisi='" + this.txtKodeDivisi.Text + "'");
                }
                else
                {
                    foreach (Control c in this.Controls)
                    {
                        if (c is TextBox && c != null)
                        {
                            if (c.Name == "txtKodeDivisi")
                            {
                                txtNamaDivisi.Text = "";
                                txtKodeGroup.Text = "";
                                txtNamaGroup.Text = "";
                                txtKodeKategori.Text = "";
                                txtNamaKategori.Text = "";
                            }
                        }
                        else if (c is CheckBox)
                        {
                            ((CheckBox)c).Checked = false;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //F1 KeyUp KodeGroup
        private void txtKodeGroup_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                this.searchKodeBarang_clicked = false;
                this.searchKodeDivisi_clicked = false;
                this.searchKodeGroup_clicked = true;
                this.searchKodeKategori_clicked = false;

                this.myQuery = "Select KodeGroup,NamaGroup from SuGroup where KodeDivisi='" + txtKodeDivisi.Text + "'";

                var search = new FrmCariData();
                search.ShowDialog(this);

                txtKodeKategori.Text = null;
                this.txtKodeGroup.Text = value;
                value = "";
            }
        }

        //KodeGroup Change
        private void txtKodeGroup_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = DBUtils.GetDbConnection();
            conn.Open();

            string query = ("Select * from SuGroup Where KodeGroup = @KodeGroupValue");

            //MySqlCommand command = new MySqlCommand(query, conn);
            //MySqlDataReader reader = command.ExecuteReader();

            MySqlCommand command = new MySqlCommand();
            command.CommandText = query;
            command.Parameters.AddWithValue("@KodeGroupValue", txtKodeGroup.Text);
            command.Connection = conn;
            MySqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                this.txtNamaGroup.Text = md.vlookup("NamaGroup", "SuGroup", "KodeGroup='" + this.txtKodeGroup.Text + "'");
            }
            else
            {
                foreach (Control c in this.Controls)
                {
                    if (c is TextBox && c != null)
                    {
                        if (c.Name == "txtKodeGroup")
                        {
                            txtNamaGroup.Text = "";
                            txtKodeKategori.Text = "";
                            txtNamaKategori.Text = "";
                        }
                    }

                    else if (c is CheckBox)
                    {
                        ((CheckBox)c).Checked = false;
                    }

                }
            }
        }

        //F1 KeyUp KodeKategori
        private void txtKodeKategori_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                this.searchKodeBarang_clicked = false;
                this.searchKodeDivisi_clicked = false;
                this.searchKodeGroup_clicked = false;
                this.searchKodeKategori_clicked = true;

                this.myQuery = "select KodeKategori,NamaKategori from SuKategori where KodeGroup='" + txtKodeGroup.Text + "'";

                var search = new FrmCariData();
                search.ShowDialog(this);

                this.txtKodeKategori.Text = value;
                value = "";
            }
        }

        //KodeKategori Change
        private void txtKodeKategori_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = DBUtils.GetDbConnection();
            conn.Open();

            string query = ("Select * from SuKategori Where KodeKategori = @KodeKategoriValue ");

            //MySqlCommand command = new MySqlCommand(query, conn);
            //MySqlDataReader reader = command.ExecuteReader();

            MySqlCommand command = new MySqlCommand();
            command.CommandText = query;
            command.Parameters.AddWithValue("@KodeKategoriValue", txtKodeKategori.Text);
            command.Connection = conn;
            MySqlDataReader reader = command.ExecuteReader();


            if (reader.HasRows)
            {
                reader.Read();
                this.txtNamaKategori.Text = md.vlookup("NamaKategori", "SuKategori", "KodeKategori='" + this.txtKodeKategori.Text + "'");
            }

            else
            {
                foreach (Control c in this.Controls)
                {
                    if (c is TextBox && c != null)
                    {
                        if (c.Name == "txtKodeKategori")
                        {
                            txtNamaKategori.Text = "";
                        }
                    }

                    else if (c is CheckBox)
                    {
                        ((CheckBox)c).Checked = false;
                    }

                }
            }
        }

    }   
}
