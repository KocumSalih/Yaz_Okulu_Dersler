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

    public partial class BasvuruSil : System.Web.UI.Page
    {
        private IBasvuruBusiness basvuruBusiness = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            basvuruBusiness = new BasvuruBusiness();

            int basvuruId = Convert.ToInt32(Request.QueryString["BasvuruId"]);
            EntityBasvuruForm form = basvuruBusiness.Listele().FirstOrDefault(t0=>t0.BasvuruId==basvuruId);
            basvuruBusiness.Sil(form);
        }
    }
}