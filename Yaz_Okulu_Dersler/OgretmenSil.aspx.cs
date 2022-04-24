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

    public partial class OgretmenSil : System.Web.UI.Page
    {
        private IOgretmenBusiness ogretmenBusiness = null;

        public OgretmenSil()
        {
            ogretmenBusiness = new OgretmenBusiness();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            int ogrtId =Convert.ToInt32( Request.QueryString["OgrtID"]);
            EntityOgretmen ogretmen = ogretmenBusiness.Listele().FirstOrDefault(t0 => t0.OgrtId == ogrtId);
            ogretmenBusiness.Sil(ogretmen);
            Response.Redirect("OgretmenSayfasi.aspx");
        }
    }
}