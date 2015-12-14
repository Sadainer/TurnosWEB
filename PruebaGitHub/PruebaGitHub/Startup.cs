using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PruebaGitHub.Startup))]
namespace PruebaGitHub
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
