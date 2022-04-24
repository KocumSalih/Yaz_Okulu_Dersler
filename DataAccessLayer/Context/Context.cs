using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Context
{
    public class Context
    {
        public static SqlConnection Connection = new SqlConnection(@"Data Source=DESKTOP-DPKMFQT\S2019;Initial Catalog=DBYAZOKULU;Persist Security Info=True;User ID=sa;Password=1");

    }
}
