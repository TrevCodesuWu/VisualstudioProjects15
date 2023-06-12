using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(workingapplication.Startup))]
namespace workingapplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
