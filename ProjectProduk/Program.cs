using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectProduk
{
    class Program
    {
        static List<Produk> daftarProduk = new List<Produk>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";
            //bool loop = true;
            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahProduk();
                        break;

                    case 2:
                        HapusProduk();
                        break;

                    case 3:
                        TampilProduk();
                        break;

                    case 4:
                        //loop = false;
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine(" Menu yang anda pilih tidak tersedia");
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();
            Console.WriteLine("Pilih menu Aplikasi ");
            Console.WriteLine("");
            Console.WriteLine("1. Tambah Produk");
            Console.WriteLine("2. Hapus Produk ");
            Console.WriteLine("3. Tampilkan Produk");
            Console.WriteLine("4. Keluar");
        }

        static void TambahProduk()
        {
            
            Console.Clear();

            //Produk produk = new Produk();
            Console.WriteLine("Tambah Data Produk");
            Console.Write("\nKode Produk : ");
            string _Library = (Console.ReadLine());
            Console.Write("Nama Produk : ");
            string _nama = (Console.ReadLine());
            Console.Write("Harga Beli : ");
            double _modal = double.Parse(Console.ReadLine());
            Console.Write("Harga Jual : ");
            double _jual = double.Parse(Console.ReadLine());

            _produk(_Library,_nama,_modal,_jual);

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusProduk()
        {
            Console.Clear();

            int no = -1, hapus = -1;
            Console.WriteLine("Hapus Data Produk");
            Console.Write("Kode Produk : ");
            string kode = Console.ReadLine();
            foreach (Produk produk in daftarProduk)
            {
                no++;
                if(produk.Library == kode)
                {
                    hapus = no;
                }
            }
            if (hapus != -1)
            {
                daftarProduk.RemoveAt(hapus);
                Console.WriteLine("\nData produk berhasil di hapus");
            }
            else
            {
                Console.WriteLine("\nKode produk tidak ditemukan");
            }

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilProduk()
        {
            Console.Clear();

            int noUrut = 1;
            Console.WriteLine("Data Produk");
            foreach (Produk produk in daftarProduk)
            {
                noUrut++;
                Console.WriteLine("{0}." + " " + " Kode.{1}" + " \t " + "Nama: {2}" + " Harga Beli: {3}" + " Harga Jual: {4}", 
                    noUrut, produk.Library, produk.Nama, produk.Modal, produk.Jual);
                noUrut++;
            }
            if (noUrut < 1)
            {
                Console.WriteLine("Data Produk Kosong");
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
        static void _produk(string _library,string _nama, double _modal,double _jual )
            {
            daftarProduk.Add(new Produk {Library = _library, Nama = _nama, Modal = _modal, Jual = _jual  });
            }
    }
}
