using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.VM
{
    public class DerslerSayfasiTablosuVm
    {
        public int DersId { get; set; }
        public string DersAdi { get; set; }
        public string OgrtAdSoyad { get; set; }
        public byte DersMinKont { get; set; }
        public byte DersMaxKont { get; set; }
        public int BasvuranSayisi { get; set; }
    }
}
