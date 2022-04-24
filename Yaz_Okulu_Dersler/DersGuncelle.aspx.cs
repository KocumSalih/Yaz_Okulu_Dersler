using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Yaz_Okulu_Dersler.Ders_Sayfalari
{
    using BusinessLogicLayer.Abstract;
    using BusinessLogicLayer.Concreate;
    using EntityFramework;

    public partial class DersGüncelle : System.Web.UI.Page
    {
        private IDersBusiness dersBusiness = null;
        public DersGüncelle()
        {
            dersBusiness = new DersBusiness();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack==false)
            {
                int dersId = Convert.ToInt32(Request.QueryString["DersId"]);
                if (dersId > 0)
                {
                    EntityDers ders = dersBusiness.Listele().FirstOrDefault(t0 => t0.DersId == dersId);
                    txtDersId.Text = ders.DersId.ToString();
                    txtDersId.Enabled = false;
                    txtDersAdi.Text = ders.DersAdi;
                    txtMaxKont.Text = ders.DersMaxKont.ToString();
                    txtMinKont.Text = ders.DersMinKont.ToString();
                } 
            }
        }

        protected void btnDersGuncelle_Click(object sender, EventArgs e)
        {
            int dersId = Convert.ToInt32(txtDersId.Text);
            if (dersId > 0)
            {
                EntityDers ders = new EntityDers()
                {
                    DersId = dersId,
                    DersAdi = txtDersAdi.Text,
                    DersMaxKont = Convert.ToByte(txtMaxKont.Text),
                    DersMinKont = Convert.ToByte(txtMinKont.Text)
                };

                dersBusiness.Guncelle(ders);
                Response.Redirect("DersSayfasi.aspx");
            }
        }
    }
}