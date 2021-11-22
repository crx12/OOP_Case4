using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CASE4
{
    public class Kasir: ProgramKasir
    {
        public DateTime tgl;
        public void tgltransaksi()
        {
            tgl = DateTime.Today;
            Console.WriteLine("Tanggal Transaksi : {0}", tgl.ToString("dd/MM/yyyy"));
        }

    }
}
