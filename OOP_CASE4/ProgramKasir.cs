using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CASE4
{
    public class ProgramKasir
    {
        public string nama;
        public string role;

        public string Name
        {
            get { return nama; }
            set { nama = value; }
        }

        public string Rule
        {
            get { return role; }
            set { role = value; }
        }
        public void login()
        {

        }
        public void datauser()
        {
            Console.WriteLine("Nama Anda : {0}", nama);
            Console.WriteLine("Role Anda : {0}", role);
        }
    }
}
