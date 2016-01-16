using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Dixons_ASP.NET_LDV
{
    public partial class Homepage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["email"] != null)
            {
                lblIngelogd.Text = "Ingelogd als: " + Session["email"].ToString();
                
            }

        }
    }
}