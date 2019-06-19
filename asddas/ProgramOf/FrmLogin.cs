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
    public partial class FrmLogin : Form
    {
        public string namauser { get; set; }

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.namauser = this.txtUserid.Text;
            string password = txtPassword.Text;
            try
            {

                MySqlConnection conn = DBUtils.GetDbConnection();
                conn.Open();

                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM tbusermst WHERE NamaUser = '" + txtUserid.Text + "'", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count <= 0)
                {
                    MessageBox.Show("Incorrect Username or Password");
                }
                else
                {
                    this.Hide();
                    FrmMenuUtama fmu = new FrmMenuUtama(this);
                    fmu.ShowDialog(this);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        
    }
}
