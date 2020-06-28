using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AplikasiPekerja.ClassInduk;
namespace AplikasiPekerja.ClassAnak

{
    public class PekerjaHarian : Pekerja
    {
        public int UpahPerJam { get; set; }
        public int JumlahJamKerja { get; set; }

        public override int Gaji() => UpahPerJam * JumlahJamKerja;


    }
}