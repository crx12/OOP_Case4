using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CASE4
{
    public class AdmStock: ProgramKasir
    {
        private int stok;
        private string barang;
        public void inputstok()
        {
            Console.Write("Masukkan Nama barang yang akan distok : ");
            barang = Console.ReadLine();
            Console.Write("Masukan Jumlah stok untuk barang {0} : ", barang);
            stok = Convert.ToInt32(Console.ReadLine());

        }
        public void readstok()
        {
            Console.WriteLine("Nama Barang : {0}", barang);
            Console.WriteLine("Stok barang sekarang : {0}", stok);
        }
        public void tambahstok()
        {
            Console.WriteLine("Update stok untuk barang {0} ", barang);
            Console.Write("Masukkan tambahan stok barang : ");
            int upstok = Convert.ToInt32(Console.ReadLine());
            stok += upstok;
        }
        public void kurangstok()
        {
            Console.WriteLine("Update stok untuk barang {0} ", barang);
            Console.Write("Masukkan pengurangan stok barang : ");
            int downstok = Convert.ToInt32(Console.ReadLine());
            stok -= downstok;
        }
    }
}
