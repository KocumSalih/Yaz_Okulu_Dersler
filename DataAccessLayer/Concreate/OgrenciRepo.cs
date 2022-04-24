using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concreate
{
    using DataAccessLayer.Abstract;
    using EntityFramework;
    using Context;
    using System.Data.SqlClient;

    public class OgrenciRepo : GenelRepo<EntityOgrenci>, IOgrenciRepo
    {
        public EntityOgrenci OgrenciBul(int Id)
        {
            EntityOgrenci _EntityOgrenci = null;

            try
            {
                SqlCommand command = new SqlCommand("select * from tblOgrenci where OgrId=@p1", Context.Connection);
                command.Parameters.AddWithValue("@p1", Id);

                if (Context.Connection.State == System.Data.ConnectionState.Closed)
                    Context.Connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    _EntityOgrenci = new EntityOgrenci();
                    _EntityOgrenci.OgrId = Convert.ToInt32(reader["OgrId"]);
                    _EntityOgrenci.OgrAd = reader["OgrAd"].ToString();
                    _EntityOgrenci.OgrSoyad = reader["OgrSoyad"].ToString();
                    _EntityOgrenci.OgrNumara = reader["OgrNumara"].ToString();
                    _EntityOgrenci.OgrFotograf = reader["OgrFotograf"].ToString();
                    _EntityOgrenci.OgrSifre = reader["OgrSifre"].ToString();
                    _EntityOgrenci.OgrBakiye = Convert.ToDouble(reader["OgrBakiye"]);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                if (Context.Connection.State == System.Data.ConnectionState.Open)
                    Context.Connection.Close();
                
            }
            return _EntityOgrenci;
        }
    }
}
