using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AplikasiPekerja.ClassInduk;
namespace AplikasiPekerja.ClassAnak

{
    public class PekerjaTetap : Pekerja
    {
        public int GajiBulanan { get; set; }


        public override int Gaji() => GajiBulanan;

    }
}