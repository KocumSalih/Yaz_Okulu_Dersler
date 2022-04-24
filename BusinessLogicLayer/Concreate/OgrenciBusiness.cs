using BusinessLogicLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concreate;
using EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Concreate
{
    public class OgrenciBusiness : IOgrenciBusiness
    {
        IOgrenciRepo ogrenciRepo = null;

        public OgrenciBusiness()
        {
            ogrenciRepo = new OgrenciRepo();
        }

        public int Ekle(EntityOgrenci entity)
        {
            return ogrenciRepo.Ekle(entity);
        }

        public int Guncelle(EntityOgrenci Entity)
        {
            return ogrenciRepo.Guncelle(Entity);
        }

        public List<EntityOgrenci> Listele()
        {
            return ogrenciRepo.Listele(System.Reflection.MethodBase.GetCurrentMethod().Name);
        }

        public EntityOgrenci OgrenciBul(int Id)
        {
           return ogrenciRepo.OgrenciBul(Id);
        }

        public void Sil(EntityOgrenci Entity)
        {
            ogrenciRepo.Sil(Entity, System.Reflection.MethodBase.GetCurrentMethod().Name);
        }
    }
}
