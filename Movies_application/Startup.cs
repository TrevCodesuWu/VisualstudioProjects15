using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Movies_application.Startup))]
namespace Movies_application
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
