using EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Abstract
{
    public interface IOgrenciBusiness:IGenelBusiness<EntityOgrenci>
    {
        EntityOgrenci OgrenciBul(int Id);
    }
}
