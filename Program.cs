using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectMahasiswa
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek mahasiswa
        static List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahMahasiswa();
                        break;

                    case 2:
                        HapusMahasiswa();
                        break;

                    case 3:
                        TampilMahasiswa();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();
            Console.Title = "Responsi Pemrograman";
            Console.Write(" Pilih Menu :");
            Console.WriteLine();
            Console.Write("1.Tambah Mahasiswa");
            Console.WriteLine();
            Console.Write("2.Hapus Mahasiswa");
            Console.WriteLine();
            Console.Write("3.Tampilkan Mahasiswa");
            Console.WriteLine();
            Console.Write("4.Keluar");
            Console.WriteLine();

            // PERINTAH: lengkapi kode untuk menampilkan menu
        }

        static void TambahMahasiswa()
        {
            Console.Clear();

            Console.WriteLine("Tambah Mahasiswa");
            Console.Write("Nim : ");
            string nim = Console.ReadLine();
            Console.Write("Nama : ");
            string nama = Console.ReadLine();
            Console.Write("IPK: ");
            string ipk = Console.ReadLine();
            Console.Write("Jenis Kelamin [L/P] : ");
            string jenis = Console.ReadLine();
            if (jenis == "L")
            {
                jenis = "Laki-laki";
            }
            else
            {
                jenis = "Perempuan";
            }
            Console.Write("Data Mahasiswa: ");
            double total = Convert.ToDouble(Console.ReadLine());

            daftarMahasiswa.Add(new Mahasiswa() { Nim = nim, Nama = nama, IPK = ipk, Jenis = jenis, Total = total });


            // PERINTAH: lengkapi kode untuk menambahkan objek mahasiswa ke dalam collection

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusMahasiswa()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menghapus objek mahasiswa dari dalam collection
            Console.WriteLine("Hapus Data Penjualan");
            string hapus;
            Console.WriteLine("Nota : ");
            hapus = Console.ReadLine();
            int x = 0;
            foreach (Mahasiswa penjualan in daftarMahasiswa)
            {
                if (hapus == penjualan.Nama)
                {
                    daftarMahasiswa.RemoveAt(x);
                    Console.WriteLine("Data Penjualan Berhasil Dihapus");
                    break;

                }
                x++;
                Console.WriteLine("Nama tidak ditemukan");
            }

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilMahasiswa()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan daftar mahasiswa yang ada di dalam collection
            Console.WriteLine("Data Mahasiswa");
            int no = 1;
            foreach (Mahasiswa penjualan in daftarMahasiswa)
            {
                Console.WriteLine("{0}. {1}, {2}, {3}, {4}, {5}",
                no, Mahasiswa.nama, Mahasiswa.nama, Mahasiswa.ipk, Mahasiswa.jenis, penjualan.Total);
                no++;
            }
            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
