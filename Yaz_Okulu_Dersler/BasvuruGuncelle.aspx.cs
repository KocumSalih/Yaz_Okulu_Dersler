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
    using EntityFramework.VM;

    public partial class BasvuruGuncelle : System.Web.UI.Page
    {
        private IBasvuruBusiness basvuruBusiness = null;
        private IDersBusiness dersBusiness = null;
        private IOgrenciBusiness ogrenciBusiness = null;
        private IOgretmenBusiness ogretmenBusiness = null;

        public BasvuruGuncelle()
        {
            basvuruBusiness = new BasvuruBusiness();
            dersBusiness = new DersBusiness();
            ogrenciBusiness = new OgrenciBusiness();
            ogretmenBusiness = new OgretmenBusiness();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                int id = Convert.ToInt32(Request.QueryString["BasvuruId"]);
                EntityBasvuruForm basvuru = basvuruBusiness.Listele().FirstOrDefault(t0=>t0.BasvuruId==id);
                if (basvuru!=null)
                {
                    txtBasvuruId.Text = basvuru.BasvuruId.ToString();
                    txtBasvuruId.Enabled = false;
                    FillOgretmen(basvuru.OgrtId);
                    FillOgrenci(basvuru.OgrId);
                    FillDers(basvuru.DersId); 
                }              
            }
        }
        private void FillDers(int id)
        {
            DropDownDers.DataSource = null;
            DropDownDers.DataSource = dersBusiness.Listele(); ;
            DropDownDers.DataTextField = "DersAdi";
            DropDownDers.DataValueField = "DersId";
            DropDownDers.DataBind();
            DropDownDers.Items.FindByValue(id.ToString()).Selected = true;
        }

        private void FillOgrenci(int id)
        {
            List<EntityOgrenci> ogrenci = ogrenciBusiness.Listele();
            DropDownOgr.DataSource = null;            
            DropDownOgr.DataSource = ogrenciBusiness.Listele();
            DropDownOgr.DataTextField = "OgrAd_Soyad_Numara";
            DropDownOgr.DataValueField = "OgrId";
            DropDownOgr.DataBind();
            //DropDownOgr.SelectedIndex = ogrenci.FindIndex(t0 => t0.OgrId == id);
            //DropDownOgr.SelectedItem = id.ToString();
            DropDownOgr.Items.FindByValue(id.ToString()).Selected = true;
        }

        private void FillOgretmen(int id)
        {
            DropDownOgrt.DataSource = null;
            DropDownOgrt.DataSource = ogretmenBusiness.Listele();
            DropDownOgrt.DataTextField = "OgrtAdSoyad";
            DropDownOgrt.DataValueField = "OgrtId";
            DropDownOgrt.DataBind();
            DropDownOgrt.Items.FindByValue(id.ToString()).Selected = true;
        }

        protected void btnBaşvuruKaydet_Click(object sender, EventArgs e)
        {
            int basvuruId = Convert.ToInt32(txtBasvuruId.Text);
            int dersId = Convert.ToInt32(DropDownDers.SelectedValue);
            int ogrId = Convert.ToInt32(DropDownOgr.SelectedValue);
            int ogrtId = Convert.ToInt32(DropDownOgrt.SelectedValue);

            if (basvuruId>0 && dersId>0 && ogrId>0 && ogrtId>0)
            {
                EntityBasvuruForm basvuru = new EntityBasvuruForm()
                {
                    BasvuruId=basvuruId,
                    DersId=dersId,
                    OgrId=ogrId,
                    OgrtId=ogrtId
                };
                basvuruBusiness.Guncelle(basvuru);
            }
            Response.Redirect("BasvuruFormu.aspx");
        }
    }
}