using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NomadCars.Startup))]
namespace NomadCars
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
