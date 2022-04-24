using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    using EntityFramework;
    public interface IOgretmenRepo : IGenelRepo<EntityOgretmen>
    {
    }
}
