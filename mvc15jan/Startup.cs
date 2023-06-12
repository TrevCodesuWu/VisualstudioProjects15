using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvc15jan.Startup))]
namespace mvc15jan
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
