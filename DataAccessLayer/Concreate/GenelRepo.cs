using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concreate
{
    using Abstract;
    using Context;
    using EntityFramework;
    using System.Data.SqlClient;
    using System.Reflection;

    public class GenelRepo<T> : IGenelRepo<T> where T:class
    {
        private SqlConnection connection;
        private SqlCommand command;
        private int donenDeger;

        private EntityBasvuruForm _EntityBasvuruForm=null;
        private EntityDers _EntityDers=null;
        private EntityOgrenci _EntityOgrenci = null;
        private EntityOgretmen _EntityOgretmen = null;

        private List<EntityBasvuruForm> _ListEntityBasvuruForm = null;
        private List<EntityDers> _ListEntityDers = null;
        private List<EntityOgrenci> _ListEntityOgrenci = null;
        private List<EntityOgretmen> _ListEntityOgretmen = null;

        public static string t()
        {

            MethodInfo sm = typeof(T).GetMethod("SomeMethod");
           string a= System.Reflection.MethodBase.GetCurrentMethod().Name;
            string methodName = sm.Name;
            T mbc = (T)Activator.CreateInstance(typeof(T));

            return typeof(T).Name;
        }

        private void AyarlariYap(T entity,string method)
        {
            donenDeger = 0;

            connection = Context.Connection;
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();

            command = new SqlCommand();
            command.Connection = connection;

            string entityName = entity.GetType().Name;
            GetCommand(command, entityName, entity, method);
            GetInjection(entityName);
        }

        private void GetInjection(string entityName)
        {
            switch (entityName)
            {
                case "EntityBasvuruForm":
                    _ListEntityBasvuruForm = new List<EntityBasvuruForm>();
                    break;
                case "EntityDers":
                    _ListEntityDers = new List<EntityDers>();
                    break;
                case "EntityOgrenci":
                    _ListEntityOgrenci = new List<EntityOgrenci>();
                    break;
                case "EntityOgretmen":
                    _ListEntityOgretmen = new List<EntityOgretmen>();
                    break;
                default:
                    break;
            }
        }

        private void GetCommand(SqlCommand command, string name, T entity, string method)
        {
            switch (name)
            {
                case "EntityBasvuruForm" when method == "Ekle":
                    command.CommandText = "insert tblBasvuruFormu (DersId,OgrId,OgrtId) values (@p1,@p2,@p3)";
                    command.Parameters.AddWithValue("@p1", (entity as EntityBasvuruForm).DersId);
                    command.Parameters.AddWithValue("@p2", (entity as EntityBasvuruForm).OgrId);
                    command.Parameters.AddWithValue("@p3", (entity as EntityBasvuruForm).OgrtId);
                    break;
                case "EntityBasvuruForm" when method == "Sil":
                    command.CommandText = "delete from tblBasvuruFormu where BasvuruId=@p1";
                    command.Parameters.AddWithValue("@p1", (entity as EntityBasvuruForm).BasvuruId);
                    break;
                case "EntityBasvuruForm" when method == "Guncelle":
                    command.CommandText = "update tblBasvuruFormu set OgrId=@p1, OgrtId=@p2, DersId=@p3 where BasvuruId=@p4 ";
                    command.Parameters.AddWithValue("@p1", (entity as EntityBasvuruForm).OgrId);
                    command.Parameters.AddWithValue("@p2", (entity as EntityBasvuruForm).OgrtId);
                    command.Parameters.AddWithValue("@p3", (entity as EntityBasvuruForm).DersId);
                    command.Parameters.AddWithValue("@p4", (entity as EntityBasvuruForm).BasvuruId);
                    break;
                case "EntityBasvuruForm" when method == "Listele":
                    command.CommandText = "select * from tblBasvuruFormu";
                    break;
                case "EntityDers" when method == "Ekle":
                    command.CommandText = "insert tblDersler (DersAdi,DersMaxKont,DersMinKont) values (@p1,@p2,@p3)";
                    command.Parameters.AddWithValue("@p1", (entity as EntityDers).DersAdi);
                    command.Parameters.AddWithValue("@p2", (entity as EntityDers).DersMaxKont);
                    command.Parameters.AddWithValue("@p3", (entity as EntityDers).DersMinKont);
                    break;
                case "EntityDers" when method == "Sil":
                    command.CommandText = "delete tblDersler where DersID=@p1";
                    command.Parameters.AddWithValue("@p1", (entity as EntityDers).DersId);
                    break;
                case "EntityDers" when method == "Guncelle":
                    command.CommandText = "update tblDersler set DersAdi=@p1,DersMaxKont=@p2, DersMinKont=@p3 where DersId=@p4";
                    command.Parameters.AddWithValue("@p1", (entity as EntityDers).DersAdi);
                    command.Parameters.AddWithValue("@p2", (entity as EntityDers).DersMaxKont);
                    command.Parameters.AddWithValue("@p3", (entity as EntityDers).DersMinKont);
                    command.Parameters.AddWithValue("@p4", (entity as EntityDers).DersId);
                    break;
                case "EntityDers" when method == "Listele":
                    command.CommandText = "select * from tblDersler";
                    break;
                case "EntityOgrenci" when method == "Ekle":
                    command.CommandText = "insert tblOgrenci (OgrAd,OgrSoyad,OgrNumara,OgrFotograf,OgrSifre,OgrBakiye) values (@p1,@p2,@p3,@p4,@p5,@p6)";
                    command.Parameters.AddWithValue("@p1", (entity as EntityOgrenci).OgrAd);
                    command.Parameters.AddWithValue("@p2", (entity as EntityOgrenci).OgrSoyad);
                    command.Parameters.AddWithValue("@p3", (entity as EntityOgrenci).OgrNumara);
                    command.Parameters.AddWithValue("@p4", (entity as EntityOgrenci).OgrFotograf);
                    command.Parameters.AddWithValue("@p5", (entity as EntityOgrenci).OgrSifre);
                    command.Parameters.AddWithValue("@p6", (entity as EntityOgrenci).OgrBakiye);
                    break;
                case "EntityOgrenci" when method == "Sil":
                    command.CommandText = "delete from tblOgrenci where OgrId=@p1";
                    command.Parameters.AddWithValue("@p1", (entity as EntityOgrenci).OgrId);
                    break;
                case "EntityOgrenci" when method == "Guncelle":
                    command.CommandText = "update tblOgrenci set OgrAd=@p1,OgrSoyad=@p2,OgrNumara=@p3,OgrSifre=@p4,OgrFotograf=@p5,OgrBakiye=@p7 where OgrId=@p6";
                    command.Parameters.AddWithValue("@p1", (entity as EntityOgrenci).OgrAd);
                    command.Parameters.AddWithValue("@p2", (entity as EntityOgrenci).OgrSoyad);
                    command.Parameters.AddWithValue("@p3", (entity as EntityOgrenci).OgrNumara);
                    command.Parameters.AddWithValue("@p4", (entity as EntityOgrenci).OgrSifre);
                    command.Parameters.AddWithValue("@p5", (entity as EntityOgrenci).OgrFotograf);
                    command.Parameters.AddWithValue("@p6", (entity as EntityOgrenci).OgrId);
                    command.Parameters.AddWithValue("@p7", (entity as EntityOgrenci).OgrBakiye);
                    break;
                case "EntityOgrenci" when method == "Listele":
                    command.CommandText = "select OgrId,OgrAd,OgrSoyad,OgrNumara,OgrFotograf,OgrSifre,OgrBakiye  from tblOgrenci";
                    break;
                case "EntityOgretmen" when method == "Ekle":
                    command.CommandText = "insert tblOgretmen (OgrtAdSoyad,OgrtBrans) values (@p1,@p2)";
                    command.Parameters.AddWithValue("@p1", (entity as EntityOgretmen).OgrtAdSoyad);
                    command.Parameters.AddWithValue("@p2", (entity as EntityOgretmen).OgrtBrans);
                    break;
                case "EntityOgretmen" when method == "Sil":
                    command.CommandText = "delete from tblOgretmen where OgrtId=@p1";
                    command.Parameters.AddWithValue("@p1", (entity as EntityOgretmen).OgrtId);
                    break;
                case "EntityOgretmen" when method == "Guncelle":
                    command.CommandText = "update tblOgretmen set OgrtAdSoyad=@p1, OgrtBrans=@p2 where OgrtId=@p3";
                    command.Parameters.AddWithValue("@p1", (entity as EntityOgretmen).OgrtAdSoyad);
                    command.Parameters.AddWithValue("@p2", (entity as EntityOgretmen).OgrtBrans);
                    command.Parameters.AddWithValue("@p3", (entity as EntityOgretmen).OgrtId);
                    break;
                case "EntityOgretmen" when method == "Listele":
                    command.CommandText = "select * from tblOgretmen";
                    break;
                default:
                    break;
            }
        }

        public int Ekle(T entity)
        {
            try
            {
                AyarlariYap(entity,"Ekle");
                donenDeger = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                BaglantiOff();
            }
            return donenDeger;
        }

        public int Guncelle(T entity)
        {
            try
            {
                AyarlariYap(entity,"Guncelle");
                donenDeger = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                BaglantiOff();
            }
            return donenDeger;
        }

        public List<T> Listele( string method)
        {
            try
            {
                T entity = (T)Activator.CreateInstance(typeof(T));
                AyarlariYap(entity, method);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    switch (typeof(T).Name)
                    {
                        case "EntityBasvuruForm":
                            _EntityBasvuruForm = new EntityBasvuruForm();
                            _EntityBasvuruForm.BasvuruId = Convert.ToInt32(reader["BasvuruId"]);
                            _EntityBasvuruForm.OgrId = Convert.ToInt32(reader["OgrId"]);
                            _EntityBasvuruForm.DersId = Convert.ToInt32(reader["DersId"]);
                            _EntityBasvuruForm.OgrtId = Convert.ToInt32(reader["OgrtId"]);
                            _ListEntityBasvuruForm.Add(_EntityBasvuruForm);                            
                            break;
                        case "EntityDers":
                            _EntityDers = new EntityDers();
                            _EntityDers.DersId = Convert.ToInt32(reader["DersId"]);
                            _EntityDers.DersAdi = reader["DersAdi"].ToString();
                            _EntityDers.DersMaxKont = Convert.ToByte(reader["DersMaxKont"]);
                            _EntityDers.DersMinKont = Convert.ToByte(reader["DersMinKont"]);
                            _ListEntityDers.Add(_EntityDers);
                            break;
                        case "EntityOgrenci":
                            _EntityOgrenci = new EntityOgrenci();
                            _EntityOgrenci.OgrId = Convert.ToInt32(reader["OgrId"]);
                            _EntityOgrenci.OgrAd = reader["OgrAd"].ToString();
                            _EntityOgrenci.OgrSoyad = reader["OgrSoyad"].ToString();
                            _EntityOgrenci.OgrNumara = reader["OgrNumara"].ToString();
                            _EntityOgrenci.OgrFotograf = reader["OgrFotograf"].ToString();
                            _EntityOgrenci.OgrSifre = reader["OgrSifre"].ToString();
                            _EntityOgrenci.OgrBakiye = Convert.ToDouble(reader["OgrBakiye"]);
                            _ListEntityOgrenci.Add(_EntityOgrenci);
                            break;
                        case "EntityOgretmen":
                            _EntityOgretmen = new EntityOgretmen();
                            _EntityOgretmen.OgrtId = Convert.ToInt32(reader["OgrtId"]);
                            _EntityOgretmen.OgrtAdSoyad = reader["OgrtAdSoyad"].ToString();
                            _EntityOgretmen.OgrtBrans = Convert.ToInt32(reader["OgrtBrans"]);
                            _ListEntityOgretmen.Add(_EntityOgretmen);
                            break;
                        default:
                            break;
                    }
                }
                reader.Close();
            }             
            catch (Exception ex)
            {
            }
            finally
            {
                BaglantiOff();
            }

            List<T> donecekDeger = new List<T>();
            switch (typeof(T).Name)
            {
                case "EntityBasvuruForm":
                    donecekDeger= _ListEntityBasvuruForm as List<T>;
                    break;
                case "EntityDers":
                    donecekDeger = _ListEntityDers as List<T>;
                    break;
                case "EntityOgrenci":
                    donecekDeger = _ListEntityOgrenci as List<T>;
                    break;
                case "EntityOgretmen":
                    donecekDeger = _ListEntityOgretmen as List<T>;
                    break;
                default:
                    break;
            }
            return donecekDeger;
        }

        public void Sil(T Entity,string method)
        {
            try
            {
                AyarlariYap(Entity, method);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                BaglantiOff();
            }
        }

        private void BaglantiOff()
        {
            if (Context.Connection.State == System.Data.ConnectionState.Open)
                Context.Connection.Close();
        }
    }
}
