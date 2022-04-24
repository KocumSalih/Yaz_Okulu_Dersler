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
    using EntityFramework.VM;

    public class BasvuruBusiness : IBasvuruBusiness
    {
        IBasvuruRepo basvuruRepo = null;

        public BasvuruBusiness()
        {
            basvuruRepo = new BasvuruRepo();
        }

        public int Ekle(EntityBasvuruForm entity)
        {
            return basvuruRepo.Ekle(entity);
        }

        public int Guncelle(EntityBasvuruForm Entity)
        {
            return basvuruRepo.Guncelle(Entity);
        }

        public List<EntityBasvuruForm> Listele()
        {
            return basvuruRepo.Listele(System.Reflection.MethodBase.GetCurrentMethod().Name);
        }

        public List<BasvuruSayfasiTablosuVM> ListeleVM()
        {
            return basvuruRepo.ListeleVM();
        }

        public void Sil(EntityBasvuruForm Entity)
        {
            basvuruRepo.Sil(Entity, System.Reflection.MethodBase.GetCurrentMethod().Name);
        }
    }
}
