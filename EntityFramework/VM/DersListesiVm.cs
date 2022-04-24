using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.VM
{
    public class DersListesiVm
    {
        public int DersId { get; set; }
        public string DersAdi { get; set; }
        public string OgrtAdıSoyadi { get; set; }
        public byte DersMaxKont { get; set; }
        public byte DersMinKont { get; set; }
        public byte BasvuranOgrSayisi { get; set; }
    }
}
