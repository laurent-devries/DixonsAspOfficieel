using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dixons_ASP.NET_LDV.Csharp;

namespace Dixons_ASP.NET_LDV.Pages
{
    public partial class LogIn : System.Web.UI.Page
    {
        private Administratie administratie;
        protected void Page_Load(object sender, EventArgs e)
        {
            administratie = new Administratie();
        }

        protected void btnBevestig_OnClick(object sender, EventArgs e)
        {
            int accountId = 0;
            if (administratie.FindParticulier(tbxEmail.Text, tbxWachtwoord.Text) != 0)
            {
                accountId = administratie.FindParticulier(tbxEmail.Text, tbxWachtwoord.Text);
            }

            if (accountId != 0)
            {
                Session["email"] = tbxEmail.Text;
                Session["wachtwoord"] = tbxWachtwoord.Text;

                Response.Redirect("/Pages/Homepage.aspx");
            }
            else
            {
                
            }
           

        }
    }
}