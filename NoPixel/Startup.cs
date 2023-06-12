using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NoPixel.Startup))]
namespace NoPixel
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
