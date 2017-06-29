using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FootballStatsNew.Startup))]
namespace FootballStatsNew
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
