using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSample_2.Models
{
    public class Ogrenci
    {
        public Ogrenci(string isim, string soyIsim, Lab labi)
        {
            Isim = isim;
            SoyIsim = soyIsim;
            Labi = labi;
        }

        public string Isim { get; set; }
        public string SoyIsim { get; set; }
        public Lab Labi { get; set; }

        public string OgrenciBilgi()
        {
            return $"{Isim} {SoyIsim},Labi:{Labi.LabNo}";
        }

    }
}
