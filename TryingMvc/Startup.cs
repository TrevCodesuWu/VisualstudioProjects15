using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TryingMvc.Startup))]
namespace TryingMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
