using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OutpourLanding.Startup))]
namespace OutpourLanding
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
