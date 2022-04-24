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

    public partial class OgretmenGuncelle : System.Web.UI.Page
    {
        private IOgretmenBusiness ogretmenBusiness = null;
        private IDersBusiness dersBusiness = null;

        public OgretmenGuncelle()
        {
            ogretmenBusiness = new OgretmenBusiness();
            dersBusiness = new DersBusiness();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Page.IsPostBack==false)
            {
                BranslariDoldur();
                BranslariDoldur();
                int ogrtId = Convert.ToInt32(Request.QueryString["OgrtId"]);
                EntityOgretmen ogretmen = ogretmenBusiness.Listele().FirstOrDefault(t0 => t0.OgrtId == ogrtId);
                if (ogretmen != null)
                {
                    txtOgrtId.Text = ogretmen.OgrtId.ToString();
                    txtOgrtAdSoyad.Text = ogretmen.OgrtAdSoyad;
                    DropDownDers.SelectedIndex = ogretmen.OgrtBrans - 1;
                } 
            }
        }
        private void BranslariDoldur()
        {
            DropDownDers.DataSource = null;
            DropDownDers.DataSource = dersBusiness.Listele();
            DropDownDers.DataValueField = "DersId";
            DropDownDers.DataTextField = "DersAdi";
            DropDownDers.DataBind();

        }

        protected void btnOgretmenGuncelle_Click(object sender, EventArgs e)
        {
            int ogrtId = Convert.ToInt32(txtOgrtId.Text);
            string adSoyad = txtOgrtAdSoyad.Text;
            int ogrtBrans = Convert.ToInt32(DropDownDers.SelectedValue);

            if (!String.IsNullOrEmpty(adSoyad) && ogrtBrans > 0 && ogrtId>0)
            {
                EntityOgretmen ogretmen = new EntityOgretmen()
                {
                    OgrtId = ogrtId,
                    OgrtAdSoyad = adSoyad,
                    OgrtBrans = ogrtBrans
                };
                ogretmenBusiness.Guncelle(ogretmen);
            }
            Response.Redirect("OgretmenSayfasi.aspx");
        }
    }
}