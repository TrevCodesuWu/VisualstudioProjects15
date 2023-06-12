using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(clientsmvc.Startup))]
namespace clientsmvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
