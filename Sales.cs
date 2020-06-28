using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AplikasiPekerja.ClassInduk;
namespace AplikasiPekerja.ClassAnak

{
    public class Sales : Pekerja
    {
        public int JumlahPenjualan { get; set; }
        public int Komisi { get; set; }


        public override int Gaji() => JumlahPenjualan * Komisi;

    }
}