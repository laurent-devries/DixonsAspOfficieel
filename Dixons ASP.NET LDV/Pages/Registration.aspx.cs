using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dixons_ASP.NET_LDV.Csharp;

namespace Dixons_ASP.NET_LDV
{
    public partial class Registration : System.Web.UI.Page
    {
        private Administratie administratie;
        protected void Page_Load(object sender, EventArgs e)
        {
            administratie = new Administratie();
        }

        protected void OnClick(object sender, EventArgs e)
        {
            try
            {
                int year = Convert.ToInt32(tbxGeboortedatumJaar.Text);
                int month = Convert.ToInt32(tbxGeboortedatumMaand.Text);
                int day = Convert.ToInt32(tbxGeboortedatumDag.Text);
                DateTime geboorteDateTime = new DateTime(year, month, day);

                administratie.InsertParticulierAccount(new Particulier(0, tbxVoornaam.Text, tbxAchternaam.Text, tbxTelefoonnummer.Text
                    , cbxSMSfunctie.Checked, tbxMobielnummer.Text, geboorteDateTime, null, cbxNieuwsbrief.Checked, tbxEmail.Text, tbxWachtwoord.Text
                    , "Particulier"));

                Response.Redirect("/Pages/LogIn.aspx");
            }
            catch
            {
                
            }
            
        }
    }
}