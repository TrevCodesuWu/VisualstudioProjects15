using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(videotutmvc.Startup))]
namespace videotutmvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
