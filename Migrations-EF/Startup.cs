using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Migrations_EF.Startup))]
namespace Migrations_EF
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
