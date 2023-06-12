using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Codefirstmvc.Startup))]
namespace Codefirstmvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
