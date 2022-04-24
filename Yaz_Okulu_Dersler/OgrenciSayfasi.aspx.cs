using BusinessLogicLayer;
using BusinessLogicLayer.Abstract;
using BusinessLogicLayer.Concreate;
using EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Yaz_Okulu_Dersler
{
    public partial class OgrenciListesi : System.Web.UI.Page
    {
        private IOgrenciBusiness ogrenciBusiness = null;
        public OgrenciListesi()
        {
            ogrenciBusiness = new OgrenciBusiness();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                ListeyiGuncelle();
            }
        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            string OgrAd = txtOgrAdi.Text;
            string OgrSoyad = txtOgrSoyadi.Text;
            string OgrNumara = txtOgrNumara.Text;
            string OgrSifre = txtOgrSifre.Text;
            string OgrFotograf = txtOgrFoto.Text;
            string OgrBakiye = txtOgrBakiye.Text;

            if (OgrAd != null && OgrSoyad != null && OgrNumara != null && OgrSifre != null && OgrFotograf != null && OgrBakiye != null)
            {
                EntityOgrenci ogrenci = new EntityOgrenci()
                {
                    OgrAd = OgrAd,
                    OgrSoyad = OgrSoyad,
                    OgrNumara = OgrNumara,
                    OgrSifre = OgrSifre,
                    OgrFotograf = OgrFotograf,
                    OgrBakiye = Convert.ToDouble(OgrBakiye)
                };
                ogrenciBusiness.Ekle(ogrenci);
                Response.Redirect("OgrenciSayfasi.aspx");
            }

        }

        private void ListeyiGuncelle()
        {
            Repeater1.DataSource = null;
            Repeater1.DataSource = ogrenciBusiness.Listele();
            Repeater1.DataBind();
        }
    }
}