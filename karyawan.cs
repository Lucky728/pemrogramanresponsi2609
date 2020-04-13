using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman2606
{
    class Karyawan
    {
        public string No { get; set; }
        public string Nik { get; set; }
        public string Nama { get; set; }
        public int GajiBulanan { get; set; }
        public Karyawan(string no, string nik, string nama, int gajibulanan)
        {
            No = no;
            Nik = nik;
            Nama = nama;
            if (gajibulanan < 0)
            {
                GajiBulanan = 0;
            }
            else
            {
                GajiBulanan = gajibulanan;
            }
        }

        public void DataKaryawan()
        {
            Console.WriteLine("{0} {1} {2} {3}", No.PadRight(2), Nik.PadRight(11), Nama.PadRight(10), GajiBulanan);
        }using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman2606
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan karyawan1 = new Karyawan("1.", "190302123", "Paijo", 3000000);
            Karyawan karyawan2 = new Karyawan("2.", "190302124", "Jono", 2000000);
            Console.WriteLine("No NIK/Nama               Gaji Bulanan");
            Console.WriteLine("--------------------------------------");
            karyawan1.DataKaryawan();
            karyawan2.DataKaryawan();
            Console.WriteLine();
            Console.WriteLine("Asyiiiiik kenaikan gaji 10 %");
            Console.WriteLine();
            karyawan1.NaikGaji();
            karyawan2.NaikGaji();

            Console.ReadKey();
        }
    }
}
        public void NaikGaji()
        {
            Console.WriteLine("{0} {1} {2} {3}", No.PadRight(2), Nik.PadRight(11), Nama.PadRight(10), (GajiBulanan * 110 / 100));
        }
    }
}