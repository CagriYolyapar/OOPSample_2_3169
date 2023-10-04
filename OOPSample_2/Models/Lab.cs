using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSample_2.Models
{
    public class Lab
    {
        public Lab(string labNo)
        {
            LabNo = labNo;
            Ogrenciler = new List<Ogrenci>();
        }

        public string LabNo { get; set; }
        public List<Ogrenci> Ogrenciler { get; set; }

    }
}
