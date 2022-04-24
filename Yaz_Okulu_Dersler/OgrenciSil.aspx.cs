using BusinessLogicLayer;
using BusinessLogicLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Yaz_Okulu_Dersler
{
    public partial class OgrenciSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            OgrenciBusiness ogrenciBusiness = new OgrenciBusiness();
            int id = Convert.ToInt32(Request.QueryString["OgrId"]);
            
            ogrenciBusiness.Sil(ogrenciBusiness.OgrenciBul(id));
            Response.Redirect("OgrenciSayfasi.aspx");

        }
    }
}