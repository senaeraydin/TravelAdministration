using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TourismTravelAdministration.Startup))]
namespace TourismTravelAdministration
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
