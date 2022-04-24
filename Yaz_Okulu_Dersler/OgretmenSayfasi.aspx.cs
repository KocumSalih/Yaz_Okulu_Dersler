using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Yaz_Okulu_Dersler
{
    using BusinessLogicLayer;
    using BusinessLogicLayer.Concreate;
    using EntityFramework;
    using BusinessLogicLayer.Abstract;

    public partial class Ogretmen : System.Web.UI.Page
    {
        private IOgretmenBusiness ogrentmenBusiness = null;
        private IDersBusiness dersBusiness = null;
        public Ogretmen()
        {
            ogrentmenBusiness = new OgretmenBusiness();
            dersBusiness = new DersBusiness();
        }

        protected void Page_Load(object sender, EventArgs e)
        {


            if (Page.IsPostBack == false)
            {
                ListeyiDoldur();
                BranslariDoldur();
            }
        }

        private void ListeyiDoldur()
        {
            Repeater1.DataSource = null;
            Repeater1.DataSource = ogrentmenBusiness.Listele();
            Repeater1.DataBind();
        }

        private void BranslariDoldur()
        {
            DropDownDers.DataSource = null;
            DropDownDers.DataSource = dersBusiness.Listele();
            DropDownDers.DataTextField = "DersAdi";
            DropDownDers.DataValueField = "DersId";           
            DropDownDers.DataBind();

        }

        protected void btnOgretmenKayit_Click(object sender, EventArgs e)
        {
            string adSoyad = txtOgrtAdSoyad.Text;
            int ogrtBrans = Convert.ToInt32(DropDownDers.SelectedItem.Value);

            if (!String.IsNullOrEmpty(adSoyad) && ogrtBrans>0)
            {
                EntityOgretmen ogretmen = new EntityOgretmen()
                {
                    OgrtAdSoyad = adSoyad,
                    OgrtBrans=ogrtBrans
                };
                ogrentmenBusiness.Ekle(ogretmen);
            }
            ListeyiDoldur();
        }
    }
}