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
using ProgramOf.Interface;

namespace ProgramOf.Transaksi
{
    public partial class FrmSI_LogKasir : Form,InPos
    {
        public FrmSI_LogKasir()
        {
            InitializeComponent();
        }

        public string namaUserK { get; set; }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = DBUtils.GetDbConnection();
            conn.Open();

            namaUserK = txtUser.Text;

            MySqlDataAdapter adapter = new MySqlDataAdapter("Select * From TbUserKasir Where NamaUser='" + this.txtUser.Text + "'", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            if (dt.Rows.Count <= 0)
            {
                MessageBox.Show("Incorrect Username or Password");
                foreach (Control c in this.Controls)
                {
                    if (c is TextBox && c != null)
                    {
                        if (c.Name != "txtUser")
                        {
                            c.Text = "";
                        }
                    }
                }
                txtUser.Focus();
            }
            else
            {
                this.Hide();
                var fpos = new FrmSI_TrnPOS();
                fpos.ShowDialog(this);
            }
            conn.Close();
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }
    }
}
