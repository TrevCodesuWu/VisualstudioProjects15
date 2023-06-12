using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(hw.Startup))]
namespace hw
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
