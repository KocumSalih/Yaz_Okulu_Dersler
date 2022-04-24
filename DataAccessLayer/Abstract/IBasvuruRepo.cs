using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    using EntityFramework;
    using EntityFramework.VM;

    public interface IBasvuruRepo:IGenelRepo<EntityBasvuruForm>
    {
        List<BasvuruSayfasiTablosuVM> ListeleVM();
    }
}
