using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ORMwithSql.Startup))]
namespace ORMwithSql
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
