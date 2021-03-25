using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ruta40.Site.Startup))]
namespace Ruta40.Site
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
