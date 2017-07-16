using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GestaoComercial.website.Startup))]
namespace GestaoComercial.website
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
