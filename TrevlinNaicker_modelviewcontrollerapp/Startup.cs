using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TrevlinNaicker_modelviewcontrollerapp.Startup))]
namespace TrevlinNaicker_modelviewcontrollerapp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
