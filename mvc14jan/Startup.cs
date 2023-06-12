using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvc14jan.Startup))]
namespace mvc14jan
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
