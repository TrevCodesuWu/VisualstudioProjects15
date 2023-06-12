using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TryingLogin.Startup))]
namespace TryingLogin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
