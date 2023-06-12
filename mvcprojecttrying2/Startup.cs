using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvcprojecttrying2.Startup))]
namespace mvcprojecttrying2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
