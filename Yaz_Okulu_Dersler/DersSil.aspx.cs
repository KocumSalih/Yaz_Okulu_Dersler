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

    public partial class DersSil : System.Web.UI.Page
    {
        private IDersBusiness dersBusines = null;

        public DersSil()
        {
            dersBusines = new DersBusiness();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            int dersId = Convert.ToInt32(Request.QueryString["DersId"]);
            if (dersId > 0)
            {
                EntityDers ders = dersBusines.Listele().FirstOrDefault(t0 => t0.DersId == dersId) as EntityDers;
                dersBusines.Sil(ders);
            }
            Response.Redirect("DersSayfasi.aspx");
        }
    }
}