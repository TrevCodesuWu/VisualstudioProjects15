using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PracticeGames.Startup))]
namespace PracticeGames
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
