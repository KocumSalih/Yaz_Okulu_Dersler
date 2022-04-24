using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Abstract
{
    using EntityFramework;
    using EntityFramework.VM;

    public interface IBasvuruBusiness :IGenelBusiness<EntityBasvuruForm>
    {
        List<BasvuruSayfasiTablosuVM> ListeleVM();
    }
}
