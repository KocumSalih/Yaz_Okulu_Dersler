using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concreate
{
    using EntityFramework;
    using Abstract;

    public class OgretmenRepo:GenelRepo<EntityOgretmen>,IOgretmenRepo
    {
    }
}
