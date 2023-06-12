using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(codefirstnewProjectone.Startup))]
namespace codefirstnewProjectone
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
