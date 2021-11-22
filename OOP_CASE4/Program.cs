using System;
using System.Threading;


namespace OOP_CASE4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sistem Kasir Sederhana : ");
            Console.WriteLine("1. Masuk sebagai Manajer");
            Console.WriteLine("2. Masuk sebagai Admin Stock");
            Console.WriteLine("3. Masuk sebagai Kasir");
            Console.WriteLine("4. Transaksi Pelanggan");
            Console.Write("Masukan Pilihan Anda : ");
            string pil = Console.ReadLine();
            if (pil == "1")
            {
                Manager rudi = new Manager();
                rudi.nama = "Rudi";
                rudi.role = "Manager";

                rudi.datauser();
                rudi.pelaporan();
            }
            else if (pil == "2")
            {
                AdmStock tedi = new AdmStock();
                tedi.nama = "Teddy";
                tedi.role = "Admin Stock";
                tedi.datauser();
                tedi.inputstok();
                tedi.readstok();
                Thread.Sleep(3000);
                Console.Clear();

                tedi.tambahstok();
                tedi.readstok();
                Thread.Sleep(3000);
                Console.Clear();

                tedi.kurangstok();
                tedi.readstok();
            }
            else if (pil == "3")
            {
                Kasir raize = new Kasir();
                raize.tgltransaksi();
            }
            else
            {
                Pelanggan jessica = new Pelanggan();
                jessica.transaksi();
            }
            Console.WriteLine("");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Tekan tombol apapun untuk keluar");
            Console.WriteLine("------------------------------");



        }
    }
}
