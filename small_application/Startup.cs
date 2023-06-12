using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(small_application.Startup))]
namespace small_application
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
