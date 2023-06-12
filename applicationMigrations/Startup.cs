using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(applicationMigrations.Startup))]
namespace applicationMigrations
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
