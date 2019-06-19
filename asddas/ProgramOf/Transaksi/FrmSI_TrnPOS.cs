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
using System.Globalization;
using System.Threading;
using ProgramOf.Interface;

namespace ProgramOf.Transaksi
{
    public partial class FrmSI_TrnPOS : Form, InSearch
    {
        InPos myKsr = null;
        string namaKasir = null;

        int temp;
        bool sukses;
        double diskonrp = 0, diskonpersen = 0;
        double value1, value2, value3, result;
        string TbWkf, TbWkfHdr, TbTempDtl, TbTempHdr;
        string date, NoPending;
        
        ModFunction md = new ModFunction();

        public FrmSI_TrnPOS()
        {
            InitializeComponent();
        }
        
        public string myQuery { get;  set; }
        public string value { get;  set; }
        public bool searchKodeBarang_clicked { get; set; }
        public bool searchKodeDivisi_clicked { get; set; }
        public bool searchKodeKategori_clicked { get; set; }
        public bool searchKodeGroup_clicked { get; set; }
        public bool searchKodePaket_clicked { get; set; }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            TxtJam.Text = DateTime.Now.ToLongTimeString();
            TxtTglTrn.Text = DateTime.Now.ToShortDateString();
        }


        private void FrmSI_TrnPOS_Load(object sender, EventArgs e)
        {
            TbWkf = "SiDtl9c0c";
            TbWkfHdr = "SiHdr9c0c";

            TbTempDtl = "SiTempDtl9c0c";
            TbTempHdr = "SiTempHdr9c0c";

            sukses = false;
            date = DateTime.Now.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);

            Type type = this.Owner.GetType();
            if (typeof(InPos).IsAssignableFrom(type))
            {
                myKsr = (InPos)this.Owner;
                this.namaKasir = myKsr.namaUserK;
                TxtNamaUser.Text = namaKasir;
                TxtStation.Text = md.vlookup("Station", "tbuserkasir", "NamaUser='" + TxtNamaUser.Text + "'" );
                TxtGrandTotal.Text = value1.ToString("###,###,###,###.#0", CultureInfo.InvariantCulture);
            }
            else
            {
                throw new NotSupportedException("My Owner is the not the right type!");
            }
            
            UtilityGlobal ug = new UtilityGlobal();
            string sql;
            sql = "Select * from " + TbTempHdr + " " +
                  "where NamaUser <> '" + namaKasir + "' " +
                  "Or TglTrn <> '" + date + "'";
            MySqlDataReader rd = ug.GetData(sql);
            if (rd.HasRows)
            {
                MessageBox.Show("Masih ada transaksi kemarin yang belum ditutup");
            }

            string jm;
            jm = md.vlookup("NoPending", TbWkf, "FlagAktif='1'");
            if (jm != null)
            {
                return;
            }
            
            isiBaru();
            KosongDetail();
        }

        private void TxtKodeBarang_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                searchKodeBarang_clicked = true;
                searchKodeDivisi_clicked = false;
                searchKodeGroup_clicked = false;
                searchKodeKategori_clicked = false;

                myQuery = "Select KodePaket As KodeBarang,NamaPaket as NamaBarang,NamaPaket as MerkBarang From InPaketHdr " +
                          "Union " +
                          "Select KodeBarang,Namabarang,MerkBarang From InBarangMst";

                var search = new FrmCariData();
                search.ShowDialog(this);
                this.txtKodeBarang.Text = value;
                value = "";
            }
        }

        private void TxtKodeBarang_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(txtKodeBarang.Text.Length < 1)
                {
                    if(DataGridView1.RowCount < 1)
                    {
                        MessageBox.Show("Tidak ada Data Penjualan");
                        txtKodeBarang.Focus();
                    }
                    else
                    {
                        FrmSI_TrnPosDtl fpd = new FrmSI_TrnPosDtl();
                        fpd.Show();
                    }
                }
                else
                {
                    txtMerkBarang.Text = md.vlookup("MerkBarang", "InBarangMst", "KodeBarang ='" + txtKodeBarang.Text + "'");
                    txtQty.Focus();
                }
            }
        }

        private void txtKodeBarang_Leave(object sender, EventArgs e)
        {
            if (txtKodeBarang.Text.Length > 0)
            {
                MySqlConnection conn = DBUtils.GetDbConnection();
                conn.Open();

                myQuery = "Select KodePaket As KodeBarang,NamaPaket as NamaBarang,HargaJual, NamaPaket as MerkBarang From InPaketHdr " +
                          "Where KodePaket = @KodeBarangValue " +
                          "Union select KodeBarang,Namabarang,HargaJual,MerkBarang From InBarangMst " +
                          "Where KodeBarang= @KodeBarangValue ";

                MySqlCommand cmd = new MySqlCommand(myQuery, conn);
                cmd.CommandText = myQuery;
                cmd.Parameters.AddWithValue("@KodeBarangValue", txtKodeBarang.Text);
                cmd.Connection = conn;
                MySqlDataReader rd = cmd.ExecuteReader();

                if (rd.HasRows)
                {
                    rd.Read();
                    TxtNamaBarang.Text = rd["NamaBarang"].ToString();
                    txtMerkBarang.Text = rd["MerkBarang"].ToString();
                    TxtHargaJual.Text = rd["HargaJual"].ToString();
                }
                else
                {
                    MessageBox.Show("Kode Barang itu Tidak ada!! ");
                    txtKodeBarang.Text = "";
                    txtKodeBarang.Focus();
                }
                rd.Close();
                conn.Close();
            }
        }

        private void txtKodeBarang_TextChanged(object sender, EventArgs e)
        {
            if (value.Length > 0)
            {
                MySqlConnection conn = DBUtils.GetDbConnection();
                conn.Open();

                myQuery = "Select KodePaket As KodeBarang,NamaPaket as NamaBarang,HargaJual, NamaPaket as MerkBarang From InPaketHdr " +
                          "Where KodePaket = @KodeBarangValue " +
                          "Union select KodeBarang,Namabarang,HargaJual,MerkBarang From InBarangMst " +
                          "Where KodeBarang= @KodeBarangValue ";

                MySqlCommand cmd = new MySqlCommand(myQuery, conn);
                cmd.CommandText = myQuery;
                cmd.Parameters.AddWithValue("@KodeBarangValue", txtKodeBarang.Text);
                cmd.Connection = conn;
                MySqlDataReader rd = cmd.ExecuteReader();

                if (rd.HasRows)
                {
                    rd.Read();
                    TxtNamaBarang.Text = rd["NamaBarang"].ToString();
                    txtMerkBarang.Text = rd["MerkBarang"].ToString();
                    TxtHargaJual.Text = rd["HargaJual"].ToString();

                    conn.Close();
                }
                value = "";
            }
        }

        private void txtQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CmdTerimaItem.Focus();
            }
        }

        private void txtQty_Leave(object sender, EventArgs e)
        {
            //kurang qty lama dari gridview cell click
            if (int.TryParse(txtQty.Text, out temp))
            {
                if (txtQty.Text == string.Empty)
                {
                    MessageBox.Show("Qty Tidak Boleh Kosong ! ");
                }
            }
            else
            {
                MessageBox.Show("Qty Harus diisi dengan Angka");
                txtQty.Focus();
            }
        }

        private void TxtHargaJual_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CmdTerimaItem.Focus();
            }
        }

        private void TxtHargaJual_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(TxtHargaJual.Text, out temp))
            {
                if (TxtHargaJual.Text == string.Empty)
                {
                    MessageBox.Show("Harga Jual Tidak Boleh Kosong ! ");
                }
                else if (int.Parse(TxtHargaJual.Text) < 1)
                {
                    MessageBox.Show("Harga Jual harus bernilai lebih dari 0");
                    TxtHargaJual.Text = "0";
                    TxtHargaJual.Focus();
                }
            }
            else
            {
                MessageBox.Show("Harga Jual Harus diisi dengan Angka");
                TxtHargaJual.Focus();
            }
        }

        private void CmdIsiBaru_Click(object sender, EventArgs e)
        {
            isiBaru();
        }

        private void CmdPendingTransaksi_Click(object sender, EventArgs e)
        {
            int jm;
            string jml;
            jml = md.vlookup("Count(Distinct NoPending)", TbWkf, "Flagaktif='1'");
            jm = int.Parse(jml);
            if(jm > 2)
            {

            }
        }

        private void CmdTerimaItem_Click(object sender, EventArgs e)
        {
            string sql;
            UtilityGlobal ug = new UtilityGlobal();

            sql = "Select * from " + TbTempHdr + " where NamaUser <> '" + namaKasir + "' " +
                  "Or TglTrn <> '" + date + "'";
            MySqlDataReader rd = ug.GetData(sql);
            if (rd.HasRows)
            {
                MessageBox.Show("Masih ada transaksi kemarin yang belum ditutup");
            }

            if (txtKodeBarang.Text.Length < 1)
            {
                MessageBox.Show("PLU Tidak Boleh Kosong ! ");
                txtKodeBarang.Focus();
            }

            if (txtKodeBarang.Text.Length > 0)
            {
                double jumlah, nHarga;

                if (int.TryParse(txtQty.Text, out temp))
                {
                    if (txtQty.Text == string.Empty)
                    {
                        MessageBox.Show("Qty Tidak Boleh Kosong ! ");
                    }
                    else if (int.Parse(txtQty.Text) < 1)
                    {
                        MessageBox.Show("Quantity harus bernilai lebih dari 0");
                        txtQty.Text = "0";
                        txtQty.Focus();
                    }
                    else
                    {
                        value1 = Convert.ToDouble(txtQty.Text);
                        value2 = Convert.ToDouble(TxtHargaJual.Text);
                        value3 = Convert.ToDouble(diskonrp);

                        jumlah = value1 * value2 - diskonrp;
                        nHarga = value2;
                        NoPending = md.NoOtomatis("PTR");

                        string ada;
                        ada = md.vlookup("KodeBarang", TbWkf, "KodeBarang = '" + txtKodeBarang.Text + "' and FlagAktif = '0' ");
                        if (ada != null)
                        {
                            DialogResult dialogResult = MessageBox.Show("Item tersebut Sudah Ada!, Mau di Edit ? ", "Peringatan", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                sql = "Update " + TbWkf + " set " +
                                      "Qty = '" + txtQty.Text + "'," +
                                      "Jumlah = '" + +jumlah + "', " +
                                      "Diskon = '" + Convert.ToDouble(diskonrp) + "'" +
                                      "Where KodeBarang = '" + txtKodeBarang.Text + "'";
                            }
                        }
                        else
                        {
                            CultureInfo ci = Thread.CurrentThread.CurrentCulture;
                            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");

                            sql = "Insert Into " + TbWkf + "(NoTrn, KodeBarang, NamaBarang, Harga, Qty, DiskonPersen, Diskon, Jumlah," +
                                  "FlagAktif,NamaUser,Station,NoPending)" +
                                  "values('','" + txtKodeBarang.Text + "','" + TxtNamaBarang.Text + "'," +
                                  "'" + Convert.ToDouble(nHarga) + "','" + Convert.ToDouble(txtQty.Text) + "'," +
                                  "'" + Convert.ToDouble(diskonpersen) + "','" + Convert.ToDouble(diskonrp) + "','" + Convert.ToDouble(jumlah) + "'," +
                                  " '0' ,'" + TxtNamaUser.Text + "' , '" + TxtStation.Text + "','')";

                            Thread.CurrentThread.CurrentCulture = ci;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Qty Harus diisi dengan Angka");
                    txtQty.Focus();
                }
            }
            ug.ExecuteData(sql);
            RefreshData();
            KosongDetail();
            txtKodeBarang.Focus();
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Apakah ingin keluar dari menu POS?", "Confirm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void FrmSI_TrnPOS_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        void isiBaru()
        {
            UtilityGlobal ug = new UtilityGlobal();
            ug.clearForm(this);
            ug.ExecuteData("Delete From " + TbWkf + " Where FlagAktif = '0' ");

            txtQty.Text = "0";
            TxtTotalPenjualan.Text = "0";
            TxtTotalBarangTdkDiskon.Text = "0";
            TxtTotalBarangDiskon.Text = "0";
            TxtTotalPembayaran.Text = "0";
            TxtTotalAkhir.Text = "0";
            TxtPPN.Text = "0";
            TxtDiskonPersen.Text = "0";
            TxtJumlahKupon.Text = "0";
            

            RefreshData();

            TxtNamaUser.Text = namaKasir;
            TxtStation.Text = md.vlookup("Station", "tbuserkasir", "NamaUser='" + TxtNamaUser.Text + "'");
            txtKodeBarang.Focus();
        }

        void KosongDetail()
        {
            txtKodeBarang.Text = "";
            TxtNamaBarang.Text = "";
            txtMerkBarang.Text = "";
            txtQty.Text = "0";
            TxtHargaJual.Text = "0";
        }

        void RefreshData()
        {
            
            string sql;
            TxtPPN.Text = "10";
            MySqlConnection conn = DBUtils.GetDbConnection();
            conn.Open();

            sql = "Select KodeBarang,NamaBarang,Harga,Qty,Diskon,Jumlah From " + TbWkf + " " +
                  "Where FlagAktif = '0' " +
                  "Order By KodeBarang,NamaBarang";

            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DataGridView1.DataSource = dt;
            conn.Dispose();

            UtilityGlobal ug = new UtilityGlobal();
            sql = "Select Sum(Jumlah) as jumlah From " + TbWkf + " " +
                  "Where Diskon<1 and FlagAktif=0";
            MySqlDataReader rd = ug.GetData(sql);
            if (rd.HasRows)
            {
                rd.Read();
                TxtTotalBarangTdkDiskon.Text = rd["Jumlah"].ToString();
                Double.TryParse(TxtTotalBarangTdkDiskon.Text, out value1);
            }

            sql = "Select Sum(Jumlah) as jumlah From " + TbWkf + " " +
                  "Where Diskon>'1' and FlagAktif='0'";
            MySqlDataReader rd1 = ug.GetData(sql);
            rd1 = ug.GetData(sql);
            if (rd.HasRows)
            {
                rd1.Read();
                TxtTotalBarangDiskon.Text = rd1["Jumlah"].ToString();
                Double.TryParse(TxtTotalBarangDiskon.Text, out value2);
                TxtTotalBarangDiskon.Text = value1.ToString("###,###,###,###.#0", CultureInfo.InvariantCulture);
            }

            double BrgPPN = 0;
            sql = "Select a.KodeBarang,a.Jumlah,b.FlagKenaPajak From " + TbWkf + " a " +
                  "Inner Join InBarangMst b on a.kodebarang = b.kodebarang " +
                  "Where b.flagkenapajak='1' and FlagAktif='0'";
            MySqlDataReader rd2 = ug.GetData(sql);
            if (rd2.HasRows)
            {
                rd2.Read();
                BrgPPN += Convert.ToDouble(rd2["Jumlah"]);
            }


            result = value1 + value2;
            result = result - (diskonpersen * result);
            TxtTotalPenjualan.Text = Convert.ToString(result);
            TxtTotalPenjualan.Text = result.ToString("###,###,###,###.#0", CultureInfo.InvariantCulture);

            value1 = BrgPPN * (10 / 100);
            value2 = result + value1;
            TxtPPN.Text = value1.ToString("###,###,###,###.#0", CultureInfo.InvariantCulture);
            TxtTotalAkhir.Text = value2.ToString("###,###,###,###.#0", CultureInfo.InvariantCulture);
            TxtGrandTotal.Text = result.ToString("###,###,###,###.#0", CultureInfo.InvariantCulture);

            DataGridView1.Columns[0].ReadOnly = true;
        }
    }
}
