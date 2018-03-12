using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BAPS.Startup))]
namespace BAPS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
