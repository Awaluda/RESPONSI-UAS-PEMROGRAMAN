using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectMahasiswa
{
    public class Mahasiswa
    {
        internal static int nama;
        internal static object ipk;

        public static object jenis { get; internal set; }

        // PERINTAH: lengkapi property class mahasiswa, sesuai petunjuk soal
        public string Nim { get; set; }
        public string Nama { get; set; }

        public string IPK { get; set; }

        public string Jenis { get; set; }

        public double Data { get; set; }
        public double Total { get; internal set; }
    }
}
