using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    public class EntityDers
    {
        public int DersId { get; set; }
        public string DersAdi { get; set; }
        public byte DersMaxKont { get; set; }
        public byte DersMinKont { get; set; }
        public int BasvuranSayisi { get; set; }
    }
}