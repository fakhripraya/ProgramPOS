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
    public partial class FrmCariData : Form
    {
        InSearch myOwner = null;
        ModFunction md = new ModFunction();

        string currentQuery = string.Empty;
        string value = string.Empty;
        string strval;
        bool kodebarangklik;
        bool kodedivisiklik;
        bool kodegroupklik;
        bool kodekategoriklik;
        bool kodepaketklik;
        

        public FrmCariData()
        {
            InitializeComponent();
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            MySqlConnection conn = DBUtils.GetDbConnection();
            conn.Open();

            base.OnHandleCreated(e);
            Type type = this.Owner.GetType();
            if (typeof(InSearch).IsAssignableFrom(type))
            {
                myOwner = (InSearch)this.Owner;
                this.currentQuery = myOwner.myQuery;
                MySqlDataAdapter adapter = new MySqlDataAdapter(currentQuery, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dt;
                dataGridView1.DataSource = bSource;
            }
            else
            {
                throw new NotSupportedException("My Owner is the not the right type!");
            }

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
        }

        //Search textbox
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchquery = "";

            Type type = this.Owner.GetType();
            if (typeof(InSearch).IsAssignableFrom(type))
            {
                myOwner = (InSearch)this.Owner;
                this.kodebarangklik = myOwner.searchKodeBarang_clicked;
                this.kodedivisiklik = myOwner.searchKodeDivisi_clicked;
                this.kodepaketklik = myOwner.searchKodePaket_clicked;
            }
            else
            {
                throw new NotSupportedException("My Owner is the not the right type!");
            }
            
            if (this.kodebarangklik == true)
            {
                searchquery = "Select KodeBarang,MerkBarang,NamaBarang " +
                              "From InBarangMst " +
                              "Where NamaBarang like @search " +
                              "OR MerkBarang like @search " +
                              "OR KodeBarang like @ksearch ";
            }
            else if(this.kodepaketklik == true)
            {
                searchquery = "Select KodePaket,NamaPaket " +
                              "From InPaketHdr " +
                              "Where NamaPaket like @search " +
                              "OR KodePaket like @ksearch ";
            }
            else if (this.kodedivisiklik == true)
            {
                searchquery = "Select KodeDivisi,NamaDivisi " +
                              "From SuDivisi " +
                              "Where NamaDivisi like @search " +
                              "OR KodeDivisi like @ksearch ";
            }

            MySqlConnection conn = DBUtils.GetDbConnection();
            conn.Open();

            string query = searchquery;

            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            adapter.SelectCommand.Parameters.AddWithValue("@search", "%" + txtSearch.Text + "%");
            adapter.SelectCommand.Parameters.AddWithValue("@ksearch", txtSearch.Text + "%");
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = dt;
            dataGridView1.DataSource = dt;

        }

        //Double Klik Row Header
        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var row = dataGridView1.CurrentRow;
            strval = row.Cells[0].Value.ToString();
            this.Close();
        }

        //Klik Ok
        private void btnOk_Click(object sender, EventArgs e)
        {
            var row = dataGridView1.CurrentRow;
            strval = row.Cells[0].Value.ToString();
            this.Close();
        }

        //EnterKeyDown
        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.btnOk.PerformClick();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if(strval == null)
            {
                base.OnFormClosing(e);
            }
            else
            {
                myOwner.value = strval.ToString();
                base.OnFormClosing(e);
            }
            
        }

        //klik Keluar
        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }


    }
}
