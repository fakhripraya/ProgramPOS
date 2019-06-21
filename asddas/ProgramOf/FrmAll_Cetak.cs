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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.Enterprise;

namespace ProgramOf
{
    public partial class FrmAll_Cetak : Form
    {
        public string c_tgl1, c_tgl2;
        public DataSet Myds = new DataSet();

        public FrmAll_Cetak()
        {
            InitializeComponent();
        }

        private void FrmAll_Cetak_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = DBUtils.GetDbConnection();
            conn.Open();

            if(NamaRpt)
        }
    }
}
