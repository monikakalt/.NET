using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MongoProject.Startup))]
namespace MongoProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
