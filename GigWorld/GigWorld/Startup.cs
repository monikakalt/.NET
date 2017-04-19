using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GigWorld.Startup))]
namespace GigWorld
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
