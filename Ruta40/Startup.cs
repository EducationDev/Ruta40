using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ruta40.Startup))]
namespace Ruta40
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
