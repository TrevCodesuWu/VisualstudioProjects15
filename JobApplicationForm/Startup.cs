using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JobApplicationForm.Startup))]
namespace JobApplicationForm
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
