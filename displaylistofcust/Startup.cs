using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(displaylistofcust.Startup))]
namespace displaylistofcust
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
