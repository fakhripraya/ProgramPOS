using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgramOf.DataAccess;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using System.Globalization;

namespace ProgramOf.DataAccess
{ 
    class ModFunction
    {
        public string CB(bool pilihan)
        {
            if (pilihan == true)
            {
                return "1";
            }
            else if (pilihan == false)
            {
                return "0";
            }
            else
            {
                return "";
            }
        }

        public string vlookup(string Field, string Table, string Criteria)
        {
            string query;

            MySqlConnection conn = DBUtils.GetDbConnection();
            conn.Open();

            query = " Select " + Field + "";
            query = query + " From " + Table + "";
            query = query + " Where " + Criteria + "";

            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataReader reader = command.ExecuteReader();

            try
            {
                if (reader.HasRows)
                {
                    reader.Read();
                    Field = reader[Field].ToString();
                    conn.Close();
                    return Field;
                }
                else
                {
                    return null;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public string NoOtomatis(string sumber)
        {
            string sql;
            string value = "";
            string temp, NoSekarang, NoBaru, NoAkhir;
            int PanjangNo;

            MySqlConnection conn = DBUtils.GetDbConnection();
            conn.Open();
            try
            {
                sql = "Select * from SuNoMst Where KodeSumber = '" + sumber + "'";
                MySqlCommand command = new MySqlCommand(sql, conn);
                MySqlDataReader rd = command.ExecuteReader();
                
                while (rd.Read())
                {
                    string Thn = DateTime.Now.ToString("yy", CultureInfo.InvariantCulture);
                    NoSekarang = rd["NoSekarang"].ToString();
                    NoAkhir = rd["NoAkhir"].ToString();
                    PanjangNo = NoSekarang.Length;
                    NoBaru = Convert.ToString((int.Parse(NoSekarang) + 1));
                    NoBaru = NoBaru.PadLeft(5, '0');
                    NoAkhir = Convert.ToString(int.Parse(NoAkhir));
                    NoAkhir = NoAkhir.PadLeft(5, '0');

                    if (int.Parse(NoBaru) > int.Parse(NoAkhir))
                    {
                        value = rd["NoAwal"].ToString();
                    }
                    else
                    {
                        value = NoBaru;
                    }
                }
                return value;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "";
            }
            
        }
        public object Nz(object anyValue)
        {
            if (DBNull.Value.Equals(anyValue))
            {
                anyValue = 0;
                return anyValue;
            }
            else if (anyValue.ToString().Length < 1)
            {
                anyValue = 0;
                return anyValue;
            }
            else
            {
                return anyValue;
            }
        }
    }
}
