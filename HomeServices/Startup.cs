using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HomeServices.Startup))]
namespace HomeServices
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
