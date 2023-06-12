using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ModdingDatabase.Startup))]
namespace ModdingDatabase
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
