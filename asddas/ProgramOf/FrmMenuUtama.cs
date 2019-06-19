using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProgramOf.Transaksi;

namespace ProgramOf
{
    public partial class FrmMenuUtama : Form
    {

        private FrmLogin f_login;

        public FrmMenuUtama(FrmLogin flogin)
        {
            InitializeComponent();
            f_login = flogin;
        }
        
        public string log { get; set; }

        //LoadForm
        private void FrmMenuUtama_Load(object sender, EventArgs e)
        {
            this.log = this.f_login.namauser;
            LblUserName.Text = log;
        }

        //klik MasterBarang -> Maintenance
        private void MnuMaintenanceMaster_Click(object sender, EventArgs e)
        {
            FrmMasterBarang fmb = new FrmMasterBarang(this);
            fmb.ShowDialog();
        }

        //klik MasterPaket
        private void MnuMasterPaket_Click(object sender, EventArgs e)
        {
            FrmMasterPaket fmp = new FrmMasterPaket();
            fmp.ShowDialog();
        }

        //klik Master -> Exit
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //klik Close
        private void FrmMenuUtama_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void masukPOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSI_LogKasir fksr = new FrmSI_LogKasir();
            fksr.ShowDialog();
        }

        private void keluarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
