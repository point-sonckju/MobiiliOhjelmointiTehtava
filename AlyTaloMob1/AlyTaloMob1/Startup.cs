using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AlyTaloMob1.Startup))]
namespace AlyTaloMob1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
