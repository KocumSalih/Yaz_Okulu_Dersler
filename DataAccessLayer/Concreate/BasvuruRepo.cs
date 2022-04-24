using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concreate
{
    using EntityFramework;
    using Abstract;
    using System.Data.SqlClient;
    using Context;
    using EntityFramework.VM;

    public class BasvuruRepo : GenelRepo<EntityBasvuruForm>, IBasvuruRepo
    {
        public List<BasvuruSayfasiTablosuVM> ListeleVM()
        {
            List<BasvuruSayfasiTablosuVM> basvurular = new List<BasvuruSayfasiTablosuVM>();
            try
            {
                SqlCommand command = new SqlCommand("select basvuru.BasvuruId, ders.DersAdi, ogrenci.OgrAd+' '+ogrenci.OgrSoyad as ogrAdSoyad, ogretmen.OgrtAdSoyad from tblBasvuruFormu as basvuru inner join tblDersler as ders on ders.DersId = basvuru.DersId inner join tblOgrenci as ogrenci on ogrenci.OgrId = basvuru.OgrId inner join tblOgretmen as ogretmen on ogretmen.OgrtId = basvuru.OgrtId ",Context.Connection);

                if (Context.Connection.State == System.Data.ConnectionState.Closed)
                    Context.Connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    BasvuruSayfasiTablosuVM basvuruVM = new BasvuruSayfasiTablosuVM()
                    {
                        BasvuruId = Convert.ToInt32(reader["BasvuruId"]),
                        ogrAdSoyad = reader["ogrAdSoyad"].ToString(),
                        OgrtAdSoyad = reader["OgrtAdSoyad"].ToString(),
                        DersAdi = reader["DersAdi"].ToString()
                    };
                    basvurular.Add(basvuruVM);
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
            return basvurular;
        }
    }
}
