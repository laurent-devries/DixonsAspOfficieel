using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Dixons_ASP.NET_LDV.Startup))]
namespace Dixons_ASP.NET_LDV
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
