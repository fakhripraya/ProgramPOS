using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ProgramOf.DataAccess;

namespace ProgramOf
{

    public partial class FrmMasterPaket : Form,InSearch
    {
        public string strvalue;
        public FrmMasterPaket()
        {
            InitializeComponent();
        }

        public FrmMasterPaket(string val)
        {
            strvalue = val;
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

        private void btn_IsiBaru_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox && c != null)
                {
                    if (c.Name != "txtKodePaket")
                    {
                        c.Text = "";
                    }
                }
            }
            listView1.Items.Clear();

            btnSimpan.Enabled = true;
            btnEdit.Enabled = false;
            btnHapus.Enabled = false;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnHapus_Click(object sender, EventArgs e)
        {

        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchKodePaket_Click(object sender, EventArgs e)
        {
            this.searchKodePaket_clicked = true;
            this.searchKodeBarang_clicked = false;

            this.myQuery = "select KodePaket,NamaPaket from InPaketHdr";

            var search = new FrmCariData();
            search.Show(this);
            this.txtKodePaket.Text = value;
            value = "";
        }

        private void txtKodePaket_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = DBUtils.GetDbConnection();
            conn.Open();

            string query = ("Select * from InPaketHdr Where KodePaket = @KodePaketValue ");

            //MySqlCommand command = new MySqlCommand(query, conn);
            //MySqlDataReader reader = command.ExecuteReader();

            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@KodePaketValue", txtKodePaket.Text);
            cmd.Connection = conn;
            MySqlDataReader rd = cmd.ExecuteReader();


            if (rd.HasRows)
            {
                rd.Read();
                txtNamaPaket.Text = rd["NamaPaket"].ToString();
                txtKonversi.Text = rd["Konversi"].ToString();
                txtHargaJualPaket.Text = rd["HargaJual"].ToString();
                txtKodeDivisi.Text = rd["KodeDivisi"].ToString();
                txtKodeGroup.Text = rd["KodeGroup"].ToString();
                txtKodeKategori.Text = rd["KodeKategori"].ToString();

                rd.Close();

                string sql = ("Select * from InPaketDtl where KodePaket = '" + txtKodePaket.Text + "'");
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    ListViewItem listitem = new ListViewItem();
                    listitem.SubItems.Add(dr["KodeBarang"].ToString());
                    listitem.SubItems.Add(dr["NamaBarang"].ToString());
                    listitem.SubItems.Add(dr["Satuan"].ToString());
                    listitem.SubItems.Add(dr["Qty"].ToString());
                    listitem.SubItems.Add(dr["HargaJual"].ToString());
                    listitem.SubItems.Add(dr["Jumlah"].ToString());
                    listView1.Items.Add(listitem);
                }
            }

            else
            {
                foreach (Control c in this.Controls)
                {
                    if (c is TextBox && c != null)
                    {
                        if (c.Name != "txtKodePaket")
                        {
                            c.Text = "";
                        }
                    }
                }
                listView1.Items.Clear();
            }

        }

        private void searchKodeBarang_Click(object sender, EventArgs e)
        {
            this.searchKodePaket_clicked = false;
            this.searchKodeBarang_clicked = true;

            this.myQuery = "select KodeBarang,MerkBarang,NamaBarang from InBarangMst";

            var search = new FrmCariData();
            search.Show(this);
            this.txtKodeBarang.Text = value;
        }

        private void txtKodeBarang_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = DBUtils.GetDbConnection();
            conn.Open();

            string query = ("Select * from InBarangMst Where Kodebarang = @KodeBarangValue ");

            //MySqlCommand command = new MySqlCommand(query, conn);
            //MySqlDataReader reader = command.ExecuteReader();

            MySqlCommand command = new MySqlCommand();
            command.CommandText = query;
            command.Parameters.AddWithValue("@KodeBarangValue", txtKodeBarang.Text);
            command.Connection = conn;
            MySqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                txtKodeBarang.Text = reader["KodeBarang"].ToString();
                txtNamaBarang.Text = reader["NamaBarang"].ToString();
                txtSatuan.Text = reader["Satuan"].ToString();
                txtHargaJual.Text = reader["HargaJual"].ToString();
            }
        }


        private void btnTerimaItem_Click(object sender, EventArgs e)
        {
            ListViewItem listitem = new ListViewItem();
            listitem.SubItems.Add(txtKodeBarang.Text);
            listitem.SubItems.Add(txtNamaBarang.Text);
            listitem.SubItems.Add(txtSatuan.Text);
            listitem.SubItems.Add(txtQty.Text);
            listitem.SubItems.Add(txtHargaJual.Text);
            listitem.SubItems.Add(txtJumlah.Text);
            listView1.Items.Add(listitem);
        }

        private void btnHapusItem_Click(object sender, EventArgs e)
        {

        }

        private void txtKodePaket_Enter(object sender, EventArgs e)
        {

        }
    }
}
