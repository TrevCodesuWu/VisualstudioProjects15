using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(movie_rental_system.Startup))]
namespace movie_rental_system
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
