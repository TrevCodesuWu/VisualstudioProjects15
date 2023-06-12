using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvc_actionresults.Startup))]
namespace mvc_actionresults
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
