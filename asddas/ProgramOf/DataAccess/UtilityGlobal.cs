using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ProgramOf.DataAccess
{
    class UtilityGlobal
    {
        
        public MySqlDataReader GetData(string query)
        {
            MySqlConnection conn = DBUtils.GetDbConnection();
            conn.Open();

            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader rd = cmd.ExecuteReader();
            
            return rd;
        }



        public void clearForm(Form frm)
        {
            foreach(Control c in frm.Controls)
            {
                if(c is TextBox && c != null)
                {
                    c.Text = "";
                }
                else if (c is ComboBox && c != null)
                {
                    c.Text = "";
                }
                else if (c is CheckBox && c != null)
                {
                    ((CheckBox)c).Checked = false;
                }
                else if (c is MaskedTextBox && c != null)
                {
                    c.Text = "";
                }
            }
                
        }
        
        public void ExecuteData(string command)
        {
            MySqlConnection conn = DBUtils.GetDbConnection();
            bool sukses;
            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();
            MySqlTransaction trans = conn.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);

            try
            {
                cmd.Connection = conn;
                cmd.Transaction = trans;

                sukses = true;
                cmd = conn.CreateCommand();
                cmd.CommandText = command;
                cmd.ExecuteNonQuery();

                trans.Commit();
                conn.Close();
            }
            catch(Exception ex)
            {
                trans.Rollback();
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        public string Flookup(string field, string table, string kriteria)
        {
            MySqlConnection conn = DBUtils.GetDbConnection();
            string sql;
            string Any;

            sql = "select " + field + " from " + table + " where " + kriteria + "";

            MySqlCommand cmd = new MySqlCommand(sql,conn);
            MySqlDataReader rd = cmd.ExecuteReader();

            if (rd.HasRows)
            {
                Any = rd[field].ToString();
            }
            else
            {
                Any = "";
            }

            rd.Close();
            conn.Close();
            
            return Any;
        }

    }
}
