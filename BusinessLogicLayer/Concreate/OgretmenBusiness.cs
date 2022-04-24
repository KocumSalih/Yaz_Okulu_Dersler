using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Concreate
{
    using Abstract;
    using EntityFramework;
    using DataAccessLayer.Abstract;
    using DataAccessLayer.Concreate;

    public class OgretmenBusiness : IOgretmenBusiness
    {
        private IOgretmenRepo ogretmenRepo = null;

        public OgretmenBusiness()
        {
            ogretmenRepo = new OgretmenRepo();
        }

        public int Ekle(EntityOgretmen entity)
        {
            return ogretmenRepo.Ekle(entity);
        }

        public int Guncelle(EntityOgretmen Entity)
        {
            return ogretmenRepo.Guncelle(Entity);
        }

        public List<EntityOgretmen> Listele()
        {
            return ogretmenRepo.Listele(System.Reflection.MethodBase.GetCurrentMethod().Name);
        }

        public void Sil(EntityOgretmen Entity)
        {
            ogretmenRepo.Sil(Entity,System.Reflection.MethodBase.GetCurrentMethod().Name);
        }
    }
}
