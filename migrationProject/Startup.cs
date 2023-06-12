using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(migrationProject.Startup))]
namespace migrationProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
