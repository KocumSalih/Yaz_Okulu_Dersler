using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concreate
{
    using Abstract;
    using EntityFramework;

    public class DersRepo : GenelRepo<EntityDers>, IDersRepo
    {
    }
}
