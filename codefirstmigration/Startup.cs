using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(codefirstmigration.Startup))]
namespace codefirstmigration
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
