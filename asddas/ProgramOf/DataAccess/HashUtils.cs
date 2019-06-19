using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgramOf.DataAccess;

namespace ProgramOf.DataAccess
{
    class HashUtils
    {
        public string Encrypt(string strText, string strkey)
        {
            int i , c;
            string strBuff = "";
            string chr;
            for (i = 1; i <= strText.Length; i++)
            {
                c = System.Convert.ToInt32(strText.Substring(i, 1));
                c = c + System.Convert.ToInt32(strkey.Substring((i % strkey.Length) + 1, 1));
                chr = "" + (char)c + 0xFF;
                strBuff = strBuff + chr;
            }
            return strBuff;
        }
    }
}
