using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WP.MvcIntermediario.UI.Site.Startup))]
namespace WP.MvcIntermediario.UI.Site
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
