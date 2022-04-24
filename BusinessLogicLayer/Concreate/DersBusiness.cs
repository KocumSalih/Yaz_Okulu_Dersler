using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Concreate
{
    using Abstract;
    using DataAccessLayer.Abstract;
    using DataAccessLayer.Concreate;
    using EntityFramework;

    public class DersBusiness : IDersBusiness
    {
        private IDersRepo dersRepo = null;
        public DersBusiness()
        {
            dersRepo = new DersRepo();
        }

        public int Ekle(EntityDers entity)
        {
            return dersRepo.Ekle(entity);
        }

        public int Guncelle(EntityDers Entity)
        {
            return dersRepo.Guncelle(Entity);
        }

        public List<EntityDers> Listele()
        {
            return dersRepo.Listele(System.Reflection.MethodBase.GetCurrentMethod().Name);
        }

        public void Sil(EntityDers Entity)
        {
            dersRepo.Sil(Entity,System.Reflection.MethodBase.GetCurrentMethod().Name);
        }
    }
}
