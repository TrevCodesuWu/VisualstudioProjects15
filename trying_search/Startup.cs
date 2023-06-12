using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(trying_search.Startup))]
namespace trying_search
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
