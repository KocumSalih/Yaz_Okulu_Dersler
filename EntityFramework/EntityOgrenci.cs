using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    public class EntityOgrenci
    {
        public int OgrId { get; set; }
        public string OgrAd { get; set; }
        public string OgrSoyad { get; set; }
        public string OgrNumara { get; set; }
        public string OgrFotograf { get; set; }
        public string OgrSifre { get; set; }
        public double OgrBakiye { get; set; }

        public string OgrAd_Soyad_Numara { get { return OgrAd + " " + OgrSoyad + "-" + OgrNumara; } }
    }
}