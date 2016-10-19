using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PlanYourTrip.Startup))]
namespace PlanYourTrip
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
