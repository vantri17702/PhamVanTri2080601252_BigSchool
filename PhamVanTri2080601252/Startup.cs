using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PhamVanTri2080601252.Startup))]
namespace PhamVanTri2080601252
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
