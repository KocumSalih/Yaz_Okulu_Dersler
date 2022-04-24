using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Yaz_Okulu_Dersler
{
    using BusinessLogicLayer.Abstract;
    using BusinessLogicLayer.Concreate;
    using EntityFramework;

    public partial class BasvuruFormu : System.Web.UI.Page
    {
        private IBasvuruBusiness basvuruBusiness = null;
        private IDersBusiness dersBusiness = null;
        private IOgrenciBusiness ogrenciBusiness = null;
        private IOgretmenBusiness ogretmenBusiness = null;

        public BasvuruFormu()
        {
            basvuruBusiness = new BasvuruBusiness();
            dersBusiness = new DersBusiness();
            ogrenciBusiness = new OgrenciBusiness();
            ogretmenBusiness = new OgretmenBusiness();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack==false)
            {
                FillOgretmen();
                FillOgrenci();
                FillDers();
                FillTable();
            }
        }

        private void FillDers()
        {
            DropDownDers.DataSource = null;
            DropDownDers.DataSource = dersBusiness.Listele(); ;
            DropDownDers.DataTextField = "DersAdi";
            DropDownDers.DataValueField = "DersId";
            DropDownDers.DataBind();
        }

        private void FillOgrenci()
        {
            DropDownOgr.DataSource = null;
            DropDownOgr.DataSource = ogrenciBusiness.Listele();
            DropDownOgr.DataTextField = "OgrAd_Soyad_Numara";
            DropDownOgr.DataValueField = "OgrId";
            DropDownOgr.DataBind();
        }

        private void FillOgretmen()
        {
            DropDownOgrt.DataSource = null;
            DropDownOgrt.DataSource = ogretmenBusiness.Listele();
            DropDownOgrt.DataTextField = "OgrtAdSoyad";
            DropDownOgrt.DataValueField = "OgrtId";
            DropDownOgrt.DataBind();
        }

        protected void btnBaşvuruKaydet_Click(object sender, EventArgs e)
        {
            int dersId = Convert.ToInt32(DropDownDers.SelectedItem.Value);
            int ogrenciId = Convert.ToInt32(DropDownOgr.SelectedItem.Value);
            int ogretmenId = Convert.ToInt32(DropDownOgrt.SelectedItem.Value);
            if (dersId>0 && ogrenciId>0 && ogretmenId>0)
            {
                EntityBasvuruForm basvuru = new EntityBasvuruForm()
                {
                    DersId = dersId,
                    OgrId = ogrenciId,
                    OgrtId=ogretmenId
                };
                basvuruBusiness.Ekle(basvuru);
            }
            FillTable();
        }

        private void FillTable()
        {
            Repeater1.DataSource = null;
            Repeater1.DataSource = basvuruBusiness.ListeleVM();
            Repeater1.DataBind();
        }
    }
}