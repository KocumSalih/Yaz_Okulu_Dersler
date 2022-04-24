using BusinessLogicLayer;
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
    public partial class OgrenciGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int ogrId =Convert.ToInt32( Request.QueryString["OgrId"]);
            txtOgrID.Enabled = false;
            if (Page.IsPostBack==false)
            {
                EntityOgrenci ogrenci = new OgrenciBusiness().OgrenciBul(ogrId);
                txtOgrID.Text = ogrenci.OgrId.ToString();
                txtOgrAdi.Text = ogrenci.OgrAd;
                txtOgrSoyadi.Text = ogrenci.OgrSoyad;
                txtOgrNumara.Text = ogrenci.OgrNumara;
                txtOgrSifre.Text = ogrenci.OgrSifre;
                txtOgrFoto.Text = ogrenci.OgrFotograf;
                txtOgrBakiye.Text = ogrenci.OgrBakiye.ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int ogrId = Convert.ToInt32(Request.QueryString["OgrId"]);
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
                    OgrId = ogrId,
                    OgrAd = OgrAd,
                    OgrSoyad = OgrSoyad,
                    OgrNumara = OgrNumara,
                    OgrSifre = OgrSifre,
                    OgrFotograf = OgrFotograf,
                    OgrBakiye = Convert.ToDouble(OgrBakiye)
                };
                new OgrenciBusiness().Guncelle(ogrenci); 
            }

            Response.Redirect("OgrenciSayfasi.aspx");
        }
    }
}