using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(application_fluent_api.Startup))]
namespace application_fluent_api
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
