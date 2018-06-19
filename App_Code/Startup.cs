using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MUwallet_Project.Startup))]
namespace MUwallet_Project
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
