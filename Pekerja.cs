using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikasiPekerja.ClassInduk
{
    public abstract class Pekerja
    {
        public string Nama { get; set; }
        public string Nik { get; set; }
        public string jenis_pekerja { get; set; }

        public abstract int Gaji();

    }
}