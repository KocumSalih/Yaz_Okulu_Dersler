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

    public partial class DersSayfasi : System.Web.UI.Page
    {
        private IDersBusiness dersBusiness = null;

        public DersSayfasi() => dersBusiness = new DersBusiness();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack==false)
            {
                Repeater1.DataSource = null;
                Repeater1.DataSource = dersBusiness.Listele();
                Repeater1.DataBind();
            }
        }

        protected void btnDersKaydet_Click(object sender, EventArgs e)
        {
            string dersAdi = txtDersAdi.Text;
            byte dersMaxKont = Convert.ToByte(txtMaxKont.Text);
            byte dersMinKont = Convert.ToByte(txtMinKont.Text);
            
            if (!string.IsNullOrEmpty(dersAdi) && dersMaxKont>0 && dersMinKont>0)
            {
                EntityDers ders = new EntityDers()
                {
                    DersAdi=dersAdi,
                    DersMaxKont=dersMaxKont,
                    DersMinKont=dersMinKont
                };
                dersBusiness.Ekle(ders);
            }
            Response.Redirect("DersSayfasi.aspx");
        }
    }
}