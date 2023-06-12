using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(searching_functionality.Startup))]
namespace searching_functionality
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
