using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_12thMvclearning.Startup))]
namespace _12thMvclearning
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
