using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramOf
{
    interface InSearch
    {
        string myQuery { get; }
        string value { get; set; }
        bool searchKodeBarang_clicked { get; set; }
        bool searchKodeDivisi_clicked { get; set; }
        bool searchKodeKategori_clicked { get; set; }
        bool searchKodeGroup_clicked { get; set; }
        bool searchKodePaket_clicked { get; set; }
    }
}
