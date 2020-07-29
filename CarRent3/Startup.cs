using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CarRent3.Startup))]
namespace CarRent3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
