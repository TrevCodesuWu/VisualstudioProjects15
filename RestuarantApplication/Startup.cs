using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RestuarantApplication.Startup))]
namespace RestuarantApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
