using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvc16Jan.Startup))]
namespace mvc16Jan
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
