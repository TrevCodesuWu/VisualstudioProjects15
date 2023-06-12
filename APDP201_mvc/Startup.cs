using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(APDP201_mvc.Startup))]
namespace APDP201_mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
