using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Dixons_ASP.NET_LDV.Pages
{
    public partial class ProductWijzigen : System.Web.UI.Page
    {
        private Database.Database db;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                db = new Database.Database();
            }
            else
            {
                db = new Database.Database();
            }
        }

        protected void ddlLoadProductCat1_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void ddlLoadProductCat2_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }


        protected void ddlLoadProductCat3_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}